/*Problem 1. Exchange if greater

 Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.
 Examples:

 a	b	result
 5	2	2 5
 3	4	3 4
 5.5	4.5	4.5 5.5*/

var a = 5,
    b = 2;

if (a > b) {
    console.log(b + ' ' + a);
}
else {
    console.log(a + ' ' + b);
}
