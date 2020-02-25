class SpaceAge:

    seconds = 0

    ORBITAL_PERIODS_COMPARED_TO_EARTH = [(planet, ratio * 31557600) for planet, ratio in
        (("Mercury", 0.2408467),
        ("Venus", 0.61519726),
        ("Earth", 1),
        ("Mars", 1.8808158),
        ("Jupiter", 11.862615),
        ("Saturn", 29.447498),
        ("Uranus", 84.016846),
        ("Neptune", 164.79132))
     ]

    def __init__(self, seconds):
        self.seconds = seconds
        for planet, ratio in self.ORBITAL_PERIODS_COMPARED_TO_EARTH:
            setattr(self, 'on_' + planet.lower(), self._planet_years(ratio))

    def _planet_years(self, ratio):
        return lambda ratio=ratio: round(self.seconds/ratio, 2)


