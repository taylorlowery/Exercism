import 'package:robot_simulator/orientation.dart';
import 'package:robot_simulator/position.dart';

class Robot {
  // Put your code here
  Position position;
  Orientation orientation;

  Robot(this.position, this.orientation);

  void move(String instructions){
    instructions.split('').toList().forEach((f) => obey(f));
  }

  void obey(String movement){
    switch(movement){
      case 'A':
        advance();
        break;
      case 'R':
        turn(movement);
        break;
      case 'L':
        turn(movement);
        break;
    }
  }

  void advance(){
    switch(this.orientation){
      case Orientation.north:
        this.position.y += 1;
        break;
      case Orientation.east:
        this.position.x += 1;
        break;
      case Orientation.south:
        this.position.y -= 1;
        break;
      case Orientation.west:
        this.position.x -=1;
        break;
    }
  }

  void turn(String direction){
    int index = Orientation.values.indexOf(this.orientation);
    switch(direction){
      case 'R':
        index++;
        break;
      case 'L':
        index --;
        break;
    }

    if(index < 0){
      index = Orientation.values.length - 1;
    }

    if(index >= Orientation.values.length){
      index = 0;
    }

    this.orientation = Orientation.values[index];
  }
}
