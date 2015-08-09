/*Problem 6. Larger than neighbours

 Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).*/

function appearanceCount(arr, pos) {
    if (arr[pos] > arr[pos + 1] && arr[pos] > arr[pos - 1]) {
        console.log('true');
    }
    else {
        console.log('false');
    }
}
appearanceCount([1, 2, 3, 4, 1, 2, 4, 2, 3, 1, 4, 2, 3, 2], 3);

