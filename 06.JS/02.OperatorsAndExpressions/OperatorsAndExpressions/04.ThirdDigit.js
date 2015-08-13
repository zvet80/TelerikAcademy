//Write an expression that checks for given integer if its third digit (right-to-left) is 7 
var num = 701;
console.log('Third digit 7? ' + CheckThirdDigit(num));

function CheckThirdDigit(num) {
    if (Math.floor(num / 100) % 10 == 7) {
        return true;
    } else {
        return false;
    }
}
