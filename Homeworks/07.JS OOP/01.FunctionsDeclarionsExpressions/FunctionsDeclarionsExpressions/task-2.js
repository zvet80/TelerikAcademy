//Write a function that finds all the prime numbers in a range
//It should return the prime numbers in an array
//It must throw an Error if any of the range params is not convertible to Number
//It must throw an Error if any of the range params is missing

//console.log(getPrime(1, 3));
function solve(start, end) {
    var result = [],
        i;
    if (arguments.length < 2 || arguments==='undefined') {
        throw new Error('2 arguments needed');
    } else if (isNaN(start) || isNaN(end)) {
        throw new Error('argument isNaN');
    }

    function isPrime(num) {
        var i = 0,
            maxDivisor = Math.sqrt(num);
        if (num < 2) {
            return 0;
        }
        for (i = 2; i <= maxDivisor; i += 1) {
            if (!num % i) {
                return 0;
            }
        }
        return 1;
    }

    for (i = +start; i <= +end; i += 1) {
        if (isPrime(i)) {
            result.push(i);
        }
    }
    return result;
}

module.exports = solve;