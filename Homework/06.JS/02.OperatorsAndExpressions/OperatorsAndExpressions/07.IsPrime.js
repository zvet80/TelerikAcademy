//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

var num = 37;
console.log('Prime? ' + CheckPrime(num));

function CheckPrime(n) {
    if (n < 2) return false;
    if (n == 2) return true;
    for (var i = 2; i <= Math.sqrt(n) ; i++) {
        if (n % i == 0) return false;
    }
    return true;
}

