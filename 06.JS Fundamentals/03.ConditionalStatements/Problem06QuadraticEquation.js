/*Problem 6. Quadratic equation

 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 Note: Quadratic equations may have 0, 1 or 2 real roots.

 Examples:

 a	b	c	roots
 2	5	-3	x1=-3; x2=0.5
 -1	3	0	x1=3; x2=0
 -0.5	4	-8	x1=x2=4
 5	2	8	no real roots*/

var a = 5,
    b = 2,
    c = 8,
    d = (b*b) - (4*a*c),
    x1 = (-b + Math.sqrt(d)) / (2*a),
    x2 = (-b - Math.sqrt(d)) / (2*a);




if(d == 0){
    console.log('x1=x2='+x1)
}
else if (d > 0) {
    console.log('x1='+x1 +'; '+'x2='+x2)
}
else if (d < 0) {
    console.log('no real roots')
}

