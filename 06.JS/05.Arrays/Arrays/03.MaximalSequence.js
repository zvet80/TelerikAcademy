//Problem 3. Maximal sequence
//Write a script that finds the maximal sequence of equal elements in an array.

var i,
    arr = [1, 6, 6, 6, 6, 7, 8, 9, 0],
    len = arr.length,
    count = 1,
    maxCount = 1,
    element;

for (i = 0; i < len - 1; i++) {
    if (arr[i] == arr[i + 1]) {
        count++;
        if (count > maxCount) {
            maxCount = count;
            element = arr[i]
        }
    } else {
        count = 1;
    }
}
console.log('max sequence: '+element.toString().repeat(maxCount))
