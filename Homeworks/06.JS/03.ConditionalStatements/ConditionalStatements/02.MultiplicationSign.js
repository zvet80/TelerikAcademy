//Problem 2. Multiplication Sign
//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

var a = -5,
    b = 8,
    c = -3;
Sign(a, b, c);

function Sign(a, b, c) {
    var sign = Math.sign(a) + Math.sign(b) + Math.sign(c);
    if (!isNaN(+a) && !isNaN(+b) && !isNaN(+c)) {
        if (a === 0 || b === 0 || c === 0) console.log(0);
        if (sign === -1 || sign === 3) console.log("+");
        if (sign === 1 || sign === -3) console.log("-");
    } else {
        throw new Error('not a valid number');
    }
}