/*Problem 3. Min/Max of sequence

 Write a script that finds the max and min number from a sequence of numbers.*/


var i,
    max = 0,
    min = 0,
    arr = [8,3,9,4,5];

for (i = 0; i < arr.length; i+=1) {

   if(arr[max]<arr[i]){
      max=arr[i];
   }
    if (arr[min]>arr[i]){
        min=arr[i];
    }
}
    console.log('Max = ' + max);
    console.log('Min = ' + min);