//Problem 1. Exchange if greater
//    Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
//    As a result print the values a and b, separated by a space.

var a = 5,
    b = 2;
isBigger(a, b);

function isBigger(a, b) {
    if (a > b) {
        b = b - a;
        a = a + b;
        b = a - b;
    }
    console.log(a+' '+b)
}