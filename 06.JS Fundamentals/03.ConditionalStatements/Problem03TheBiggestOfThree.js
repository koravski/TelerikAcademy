/*Problem 3. The biggest of Three

 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 Examples:

 a	b	c	biggest
 5	2	2	5
 -2	-2	1	1
 -2	4	3	4
 0	-2.5	5	5
 -0.1	-0.5	-1.1	-0.1*/

var a = 5,
    b = 2,
    c = 2;

if (a>=b) {
    if (a>=c){
        console.log(a)
    }
}

else if (b>=a) {
    if (b>=c){
        console.log(b)
    }
}

if (c>=a) {
    if (c>=b){
        console.log(c)
    }
}

