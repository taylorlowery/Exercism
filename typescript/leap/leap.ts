function makeNumeric(n: number) {
  return {
    value: n,
    isDivisibleBy(x: number) {
      return this.value % x === 0;
    },
  };
}

function isLeapYear(year: number): boolean { 
  const yearNum = makeNumeric(year);
  return (
    yearNum.isDivisibleBy(4) &&
    (!yearNum.isDivisibleBy(100) || yearNum.isDivisibleBy(400))
  );
}

export default isLeapYear;
