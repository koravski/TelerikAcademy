/*Problem 3. Maximal sequence

 Write a script that finds the maximal sequence of equal elements in an array.
 Example:

 input	result
 2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2*/

var i,
    j,
    count = 0,
    max = 0,
    number = 0,
    arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    result = new Array();

for (i = 0; i < arr.length; i+=1) {

    if(arr[i]==arr[i+1]) {
        count+=1;
    }
    else {
        count=0;
    }

    if (count>max) {
        max=count;
        number = arr[i];
    }

}

for (j = 0; j < max+1; j+=1) {
    result[j]=number;

}

console.log(result.join(','))