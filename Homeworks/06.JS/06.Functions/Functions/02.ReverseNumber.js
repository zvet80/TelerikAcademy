//Problem 2. Reverse number
//Write a function that reverses the digits of given decimal number.

var num = 5986.3;
console.log(reverseNum(num));

function reverseNum(num) {
    var rev = [];
    rev = num.toString().split('').reverse();
    return +(rev.join(''));
}