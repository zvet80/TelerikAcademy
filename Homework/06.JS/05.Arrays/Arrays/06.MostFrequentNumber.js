//Problem 6. Most frequent number
//Write a script that finds the most frequent number in an array.

var i, j,
    arr = [1, 6, 6, 6, 6, 7, 8, 9, 6],
    len = arr.length,
    count = 1,
    maxCount = 1,
    max;

for (i = 0; i < len - 1; i++) {
    for (j = i + 1; j < len; j++) {
        if (arr[i] == arr[j]) {
            count++;
        }
        if (maxCount < count) {
            max = arr[i];
            maxCount = count;
        }
    }
    count = 1;
}
if (maxCount == 1) {
    console.log('all elements are unique');
} else {
    console.log('most frequent num: ' + max + ' (' + maxCount + ' times)');
}
