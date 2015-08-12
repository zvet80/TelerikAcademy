//Write a function that sums an array of numbers:
//Numbers must be always of type Number
//Returns null if the array is empty
//Throws Error if the parameter is not passed (undefined)
//    Throws if any of the elements is not convertible to Number

//var arr = [1, 2, 3];
//console.log(sum(arr));
function solve(arr) {
    if (arr === undefined) {
        throw new Error('undefined');
    } else if (arr.length === 0) {
        return null;
    } else if (arr.some(function (num) {
            return isNaN(num);
    })) {
        throw new Error('NaN');
    }

    return arr.reduce(function (sum, num) {
        return sum += +num;
    }, 0);
}
module.exports = solve;