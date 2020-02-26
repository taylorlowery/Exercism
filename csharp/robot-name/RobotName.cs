using System;
using System.Collections.Generic;

public static class RobotRegistry
{
    private static Random _rnd = new Random();
    private static HashSet<Robot> ActiveRobots = new HashSet<Robot>();
    
    public static void RegisterRobot(Robot robot){
        robot.RenameRobot(GenerateRobotName());
        while(!ActiveRobots.Add(robot)){
            robot.RenameRobot(GenerateRobotName());
        }
    }

    private static string GenerateRobotName(){
        char a = GetRandomCharacter();
        char b = GetRandomCharacter();
        int digits = _rnd.Next(0, 1000);
        string name = $"{a}{b}{digits:D3}";
        return name;


        char GetRandomCharacter() => (char)_rnd.Next('A', 'Z' + 1);
    }

    public static void RemoveRobotFromRegistry(Robot robot)
    {
        // attempt to remove robot's name from registry whether or not it's present
        // we could track this bool to see if this was a rogue, unregistered robot, etc. 
        if (!String.IsNullOrWhiteSpace(robot.Name))
        {
            bool removed = ActiveRobots.Remove(robot);
        }
        // regardless, wipe robot's name and deactivate it.
        robot.DisableRobot();
    }
}

public class Robot : IDisposable
{
    private bool _active;
    private string _name;
    public string Name => _name;
    public bool Active => _active;
    
    public Robot() => Reset();

    ~Robot() => RobotRegistry.RemoveRobotFromRegistry(this);

    public void Dispose()
    {
        RobotRegistry.RemoveRobotFromRegistry(this);
        GC.SuppressFinalize(this);
    }

    public void Reset()
    {
        // remove robot's name from list of existing robots
        RobotRegistry.RemoveRobotFromRegistry(this);
        // generate a new name and assign it to the current robot. 
        RobotRegistry.RegisterRobot(this);
        // activate the robot
        ActivateRobot();
    }

    // These methods are sort of just for fun. 
    // I was thinking that the Robot Registry Bureau wouldn't want rogue robots to be active without being registered, 
    // so we prevent it from being active without the name
    // We can assume in a real robot there would be other methods that would only be possible if the robot were active

    public void RenameRobot(string name)
    {
        _name = name;
    }

    // prevent the robot from being activated without being registered
    public void ActivateRobot()
    {
        if (!String.IsNullOrWhiteSpace(this.Name))
        {
            _active = true;
        }
    }

    // Turn the robot on and off
    public void DeactivateRobot()
    {
        _active = false;
    }

    // Remove the robot's name and deactivate it.
    public void DisableRobot()
    {
        MemoryWipe();
        DeactivateRobot();
    }

    // wipe the robot's memory (remove its name)
    public void MemoryWipe()
    {
        _name = String.Empty;
    }

    public override bool Equals(object obj)
    {
        Robot otherRobot = obj as Robot;
        if (otherRobot == null)
        {
            return false;
        }

        return this.Name.Equals(otherRobot.Name);
    }

    public override int GetHashCode()
    {
        return this.Name.GetHashCode();
    }
}