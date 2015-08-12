//Problem 6. Larger than neighbours
//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

var k = 2,
    arr = [1, 5, 9, 6, 55, 5, 7];
if (k < 0 || k > arr.length - 1) {
    console.log('there is no such index in the array');
} else if ((k + 1 > arr.length - 1) || (k - 1 < 0)) {
    console.log('there are no two neighbours');
} else {
    console.log(checkNeighbours(k, arr));
}

function checkNeighbours(k, arr) {
    if ((arr[k] > arr[k - 1]) && (arr[k] > arr[k + 1])) {
        return true;
    } else {
        return false;
    }
}