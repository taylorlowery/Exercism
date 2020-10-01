const colorValue = {
  black: 0,
  brown: 1,
  red: 2,
  orange: 3,
  yellow: 4,
  green: 5,
  blue: 6,
  violet: 7,
  grey: 8,
  white: 9,
};

type Color = keyof typeof colorValue;

export class ResistorColor {
  private colors: [Color, Color];

  constructor(colors: [Color, Color]) {
    this.colors = colors;
  }
  value = (): number =>
    parseInt(this.colors.map((c) => colorValue[c]).join(""));
}
