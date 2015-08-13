////Problem 7. Binary search
////Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

var arr = [1,3, 4, 5, 6, 7, 8, 9],
    n = 5,
    found = false,
    begin = 0,
    end = arr.length - 1,
    key;

while (begin <= end) {
    key = Math.floor((begin + end) / 2);
    if (arr[key] === n) {
        console.log(key);
        found = true; break;
    } else if (n < arr[key]) {
        end = key - 1;        
    } else {
        begin = key + 1;
    }
}
if (found == false) {
    console.log(-1);
}
