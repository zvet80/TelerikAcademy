//Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius

var x = -4,
	y = 5;
console.log('inside: ' + inCircle(x, y));

function inCircle(x, y) {
	if ((x * x + y * y) <= 25)
		return true;
	else
		return false;
}