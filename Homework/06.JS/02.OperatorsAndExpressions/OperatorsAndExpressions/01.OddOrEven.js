//Write an expression that checks if given integer is odd or even.
var num = 65;
console.log('Odd? ' + isOdd(num));

function isOdd(num) {
    if (num % 2 === 0) {
        return false;
    }
    else {
        return true;
    }
}
