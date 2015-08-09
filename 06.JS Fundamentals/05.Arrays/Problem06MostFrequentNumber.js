/*Problem 6. Most frequent number

 Write a script that finds the most frequent number in an array.
 Example:

 input	result
 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)*/

var i,
    j,
    max = 0,
    currn,
    arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    element = arr[0];

for (i = 0; i < arr.length; i+=1) {
    currn = 0;
    for (j = 0; j < arr.length; j+=1) {
        if (arr[i] === arr[j]) {
            currn+=1;
        }
    }

    if (currn > max) {
        max = currn;
        element = arr[i];
    }
}

console.log(element + ' (' + max + ' times)');

