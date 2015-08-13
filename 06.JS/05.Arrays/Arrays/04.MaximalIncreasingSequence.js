//Problem 4. Maximal increasing sequence
//Write a script that finds the maximal increasing sequence in an array.


var i,
    arr = [1, 6, 6, 6, 6, 7, 8, 9, 0],
    len = arr.length,
    temp = [],
    max = [];
temp[0] = arr[0];
for (i = 1; i < len; i++) {
    if (arr[i] > arr[i - 1]) {
        temp.push(arr[i]);
        if (temp.length > max.length) {
            max = temp;
        }
    } else {
        temp = [arr[i]];
    }
}
console.log('max increasing sequence: ' + max.join(','));