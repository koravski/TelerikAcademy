/*Problem 5. Appearance count

 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.*/

function appearanceCount(arr, num) {

    var i,
        answer = 0;

    for (i = 0; i < arr.length; i += 1) {
        if (arr[i] == num) {
            answer += 1;
        }

    }
    return answer;
}

console.log(appearanceCount([7, 0, 6, 7, 8, 4, 6, 7, 7], 7));