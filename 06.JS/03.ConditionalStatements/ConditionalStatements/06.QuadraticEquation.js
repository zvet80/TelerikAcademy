//Problem 6. Quadratic equation
//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
//Note: Quadratic equations may have 0, 1 or 2 real roots.

var a = 2,
    b = 5,
    c = -3;
SolveEq(a, b, c);

function SolveEq(a, b, c) {
    var d = b * b - 4 * a * c,
        x1 = (-b + Math.sqrt(d)) / (2 * a),
        x2 = (-b - Math.sqrt(d)) / (2 * a);
    if (d > 0) {
        console.log('the equation has 2 roots: ' + x1 + ',' + x2)
    } else if (d === 0) {
        console.log('the equation has 1 root: ' + x1)
    } else {
        console.log('the equation has no real roots')
    }
}