//Problem 7. First larger than neighbours
//Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
//Use the function from the previous exercise.

var arr1 = [1, 5, 9, 6, 55, 5, 7],
    arr2=[1,2,3,4,5,6,7];

console.log(checkFirst(arr1));
console.log(checkFirst(arr2));

function checkFirst(arr) {
    var i,
        len = arr.length;
    for (i = 1; i < len-1; i += 1) {
        if (checkNeighbours(i, arr)) {
            return i;
        }
    }
    return -1;
}

function checkNeighbours(k, arr) {
    if ((arr[k] > arr[k - 1]) && (arr[k] > arr[k + 1])) {
        return true;
    } else {
        return false;
    }
}