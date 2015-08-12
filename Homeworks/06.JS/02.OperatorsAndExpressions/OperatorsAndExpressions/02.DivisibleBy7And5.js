//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
var num = 5;
console.log('Divisible by 7 and 5? ' + isDivisible(num));

function isDivisible(num) {
	if (num % 5 == 0 && num % 7 == 0)
		return true;
	else
		return false;
}