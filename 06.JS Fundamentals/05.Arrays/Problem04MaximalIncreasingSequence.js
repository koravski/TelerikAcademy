/*Problem 4. Maximal increasing sequence

 Write a script that finds the maximal increasing sequence in an array.
 Example:

 input	result
 3, 2, 3, 4, 2, 2, 4	2, 3, 4*/

var i,
    j,
    count = 1,
    max = 0,
    lastIndex = 0,
    results = '',
    arr = [3, 2, 3, 4, 2, 2, 4];

for (i = 1; i < arr.length; i+=1) {

    if (arr[i-1]<arr[i]) {
        count+=1;
    }
    else {
        if (max < count) {
        max = count;
        count = 1;
        lastIndex = i;
    }
    }
}

if (max < count) {
    max = count;
    lastIndex = arr.length;
}

for (j = 0; j < max; j+=1) {
    results += arr[lastIndex - max + j];
    results += ' ';
}

console.log(results);
