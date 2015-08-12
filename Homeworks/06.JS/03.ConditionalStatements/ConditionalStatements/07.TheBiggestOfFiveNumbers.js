//Problem 7. The biggest of five numbers
//Write a script that finds the greatest of given 5 variables.
//Use nested if statements.

var a = 5,
    b = 200,
    c = 8,
    d = 89,
    e = 54;
console.log('biggest number: ' + isBiggest(a, b, c, d, e));

function isBiggest(a, b, c, d, e) {
    var maxNum = a;

    if (maxNum < b) {
        maxNum = b;
    }
    if (maxNum < c) {
        maxNum = c;
    }
    if (maxNum < d) {
        maxNum = d;
    }
    if (maxNum < e) {
        maxNum = e;
    }
    return maxNum;
}

