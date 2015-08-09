/*Problem 7. First larger than neighbours

 Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.*/

function firstLarger(arr) {

    var i,
        index = 0;

    for (i = 0; i < arr.length; i += 1) {
        if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1]) {

            return i;
        }


    }
    return -1;
}
console.log(firstLarger([1, 2, 3, 4, 1, 2, 4, 2, 3, 1, 4, 2, 3, 2]));
console.log(firstLarger([1, 1, 1, 1, 1]));

