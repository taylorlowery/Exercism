import random
import string

_robots = []

alphabet = list(string.ascii_letters)


def random_robot_name():
    random.seed()
    a = random.choice(alphabet)
    b = random.choice(alphabet)
    digits = random.randint(0, 1000)
    return '{0}{1}{2:3d}'.format(a, b, digits)


def generate_unique_robot_name():
    robot_name = random_robot_name()
    while _robots.__contains__(robot_name):
        robot_name = random_robot_name()
    _robots.append(robot_name)
    return robot_name


class Robot:

    name = ""
    def reset(self):
        if self.name:
            _robots.remove(self.name)
        self.name = generate_unique_robot_name()

    def __init__(self):
        self.reset()

