//Problem 1. Reverse string
//Write a JavaScript function that reverses a string and returns it.

var str = 'abcd',
    result='',
    i,
    len = str.length-1;

for (i = len; i >= 0; i -= 1) {
    result += str[i];
}
console.log(result);
