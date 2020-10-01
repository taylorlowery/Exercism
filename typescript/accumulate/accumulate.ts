export default function accumulate<T, U>(
  inputData: T[],
  func: (x: T) => U
): U[] {
  return inputData.map(func);
}
