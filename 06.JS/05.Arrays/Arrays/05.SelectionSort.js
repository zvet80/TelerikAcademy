//Problem 5. Selection sort
//Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
//    Hint: Use a second array

var i, j,
    arr = [1, 6, 2, -3, 10, 7, 8, 29, 0],
    len = arr.length,
    temp;
    
for (i = 0; i < len - 1; i++) {
    for (j = i + 1; j < len; j++) {
        if (arr[i] > arr[j]) {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
console.log('sorted: ' + arr.join(','));