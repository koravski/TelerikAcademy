/*Problem 7. Is prime

 Write an expression that checks if given positive integer number n (n ? 100) is prime.
 Examples:

 n	Prime?
 1	false
 2	true
 3	true
 4	false
 9	false
 37	true
 97	true
 51	false
 -3	false
 0	false*/

var N = 97,
    isPrime = N < 0 || N == 1 || (N % 2 == 0 && N != 2) || (N % 3 == 0 && N != 3) || (N % 5 == 0 && N != 5) || (N % 7 == 0 && N != 7);

console.log(!isPrime);

