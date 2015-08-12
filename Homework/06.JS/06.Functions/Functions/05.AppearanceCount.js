//Problem 5. Appearance count
//Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.

var num = 7,
    arr = [1, 5, 9, 6, 55, 5, 7];
console.log(count(num, arr));
console.log(testCount());

function count(num, arr) {
    var i,
        count = 0;

    for (i = 0; i < arr.length; i += 1) {
        if (arr[i] === num) {
            count++;
        }
    }
    return count;
}
function testCount() {
    var arr1 = [1, 1, 1, 1, 5, 9, 6],
        arr2 = [6, 5, 6, 5, 6, 5];

    if ((count(1, arr1) == 4) && (count(6, arr2) == 3)) {
        return true;
    } else {
        return false;
    }
}