//Problem 3. The biggest of Three
//Write a script that finds the biggest of three numbers.
//Use nested if statements.

var a = -5,
    b = -8,
    c = -3;
Biggest(a, b, c);

function Biggest(a, b, c) {    
    if (!isNaN(a) && !isNaN(b) && !isNaN(c)) {
        if (a > b) {
            if (a > c) {
                console.log('The biggest is: ' + a);
            } else {
                console.log('The biggest is: ' + c);
            }
        } else {
            if (b < c) {
                console.log('The biggest is: ' + c);
            } else {
                console.log('The biggest is: ' + b);
            }
        }
    } else {
        throw new Error('not a valid number');
    }
}