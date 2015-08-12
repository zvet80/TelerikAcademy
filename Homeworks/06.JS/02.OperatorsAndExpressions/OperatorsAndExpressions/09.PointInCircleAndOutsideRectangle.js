//Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

var x = 4,
	y = 0;
console.log('inside K & outside of R: ' + (inCircle(x, y) && outRectangle(x, y)));

function inCircle(x, y) {
    if (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9)
        return true;
    else
        return false;
}
function outRectangle(x, y) {
    if (((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1)))
        return false;
    else
        return true;
}

