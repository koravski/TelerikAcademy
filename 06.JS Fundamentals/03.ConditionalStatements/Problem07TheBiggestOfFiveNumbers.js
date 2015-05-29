/*Problem 7. The biggest of five numbers

 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
 Examples:

 a	b	c	d	e	biggest
 5	2	2	4	1	5
 -2	-22	1	0	0	1
 -2	4	3	2	0	4
 0	-2.5	0	5	5	5
 -3	-0.5	-1.1	-2	-0.1	-0.1*/


var a = -2,
    b = 4,
    c = 3,
    d = 2,
    e = 0;

if (a>=b) {
    if (a>=c) {
        if (a>=d) {
            if (a>=e){
                console.log(a)
            }

        }
    }

}

else if (b>=a) {
        if (b>=c) {
            if (b>=d) {
                if (b>=e){
                    console.log(b)
                }

            }
        }

}

else if (c>=a) {
        if (c>=b) {
            if (c>=d) {
                if (c>=e){
                    console.log(c)
                }

            }
        }

}

else if (d>=a) {
        if (d>=b) {
            if (d>=c) {
                if (d>=e){
                    console.log(d)
                }

            }
        }

}

else if (e>a) {
        if (e>b) {
            if (e>d) {
                if (d>e){
                    console.log(e)
                }

            }
        }

}