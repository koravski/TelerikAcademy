/*Problem 7. Binary search

 Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.*/

var min = 0,
    answer = -1,
    element = 4,
    arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
    max = arr.length - 1;

    while (min <= max) {
        var mid = min + (max - min) / 2;
        mid = Math.floor(mid);
        if (arr[mid] > element) {
            max = mid - 1;
        }
        else if (arr[mid] < element) {
            min = mid + 1;
        }
        else {
            answer = mid;
            break;
        }
    }

console.log('Index of element ' + element + ' is ' + answer);

