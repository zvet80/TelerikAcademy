//Problem 2. Lexicographically comparison
//Write a script that compares two char arrays lexicographically (letter by letter).

var i,
    arr1 = ['a', 'x', 'z', 'r', 'g'],
    arr2 = ['a', 'x', 'r', 'r', 'g'],
    len1 = arr1.length,
    len2 = arr2.length,
    equal=true;


for (i = 0; i < Math.min(len1, len2) ; i += 1) {
    if (arr1[i] < arr2[i]) {
        console.log('arr1<arr2');
        equal = false;
        break;
    }
    else if (arr1[i] > arr2[i]) {
        console.log('arr1>arr2');
        equal = false;
        break;
    }
}
if (equal) {
    if (len1 > len2) {
        console.log('arr1>arr2');
    } else if (len1 < len2) {
        console.log('arr1<arr2');
    } else {
        console.log('arr1=arr2');
    }
}