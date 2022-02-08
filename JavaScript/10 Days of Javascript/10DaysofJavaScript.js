/************** Day 0: Hello, World! **************/
function greeting(parameterVariable) {
  // This line prints 'Hello, World!' to the console:
  console.log("Hello, World!");

  // Write a line of code that prints parameterVariable to stdout using console.log:
  console.log(parameterVariable);
}

/************** Day 0: Data Types **************/
// Write code that uses console.log to print the sum of the 'firstInteger' and 'secondInteger' (converted to a Number type) on a new line.
secondInteger = Number(secondInteger)
console.log(firstInteger+secondInteger)
// Write code that uses console.log to print the sum of 'firstDecimal' and 'secondDecimal' (converted to a Number type) on a new line.
secondDecimal = Number(secondDecimal)
console.log(firstDecimal+secondDecimal)
// Write code that uses console.log to print the concatenation of 'firstString' and 'secondString' on a new line. The variable 'firstString' must be printed first.
console.log(firstString+secondString)

/************** Day 1: Arithmetic Operators **************/
function getArea(length, width) {
  let area;
  // Write your code here
  area=length*width;
  return area;
}

function getPerimeter(length, width) {
  let perimeter;
  // Write your code here
  perimeter=2*(length+width);
  return perimeter;
}