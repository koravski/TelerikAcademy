/*Problem 2. Reverse number

 Write a function that reverses the digits of given decimal number.
 Example:

 input	output
 256	652
 123.45	54.321*/

function reverse(number) {
    var answer = number.toString().split('').reverse().join('');
    console.log(answer);
}

reverse(256);
reverse(123.45);