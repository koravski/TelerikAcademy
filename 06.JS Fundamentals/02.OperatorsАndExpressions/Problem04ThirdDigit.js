/*Problem 4. Third digit

 Write an expression that checks for given integer if its third digit (right-to-left) is 7.
 Examples:

 n	Third digit 7?
 5	false
 701	true
 1732	true
 9703	true
 877	false
 777877	false
 9999799	true*/


var number = 877;

console.log(Math.floor(number / 100) % 10 == 7)
