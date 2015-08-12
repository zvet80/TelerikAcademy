//Write an expression that calculates trapezoid's area by given sides a and b and height h.
var a = 0.222,
	b = 0.333,
	h = 0.555;

console.log('Trapezoid Area: ' + CalcArea(a, b, h));

function CalcArea(a, b, h) {
	return ((a + b) * h) / 2;
}