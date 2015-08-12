//Problem 1. Planar coordinates
//Write functions for working with shapes in standard Planar coordinate system.
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

var a = { x: 2, y: 6 },
    b = { x: 1, y: 5 },
    c = { x: 4, y: 5 };

console.log('distance=' + calcDist(a, b));
console.log('triangle a,b,c?' + checkTriangle(calcDist(a, b), calcDist(b, c), calcDist(a, c)));

function calcDist(p1, p2) {
    var distance = Math.sqrt(Math.pow((p1.x - p2.x), 2) + Math.pow((p1.y - p2.y), 2)).toFixed(2);
    return distance;
}
function checkTriangle(a, b, c) {
    if (((a + b) > c) && ((a + c) > b) && ((b + c) > a)) {
        return true;
    } else {
        return false;
    }
}