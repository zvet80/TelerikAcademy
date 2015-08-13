//Problem 8. Number as words
//Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

var number = 511,
    digit = Math.floor(number % 10),
    teen = Math.floor(number % 100),
    ten = Math.floor(number % 100 / 10),
    hundred = Math.floor(number / 100);

if (!hundred) {
    if (Math.floor(number / 10) == 0) {
        console.log(getDigit(digit));
    } else if (ten == 1 || digit == 0) {
        console.log(getTeen(teen));
    } else {
        console.log(getTeen(ten * 10) + ' ' + getDigit(digit));
    }
} else {
    if (ten == 1 || digit == 0) {
        console.log(getDigit(hundred) + ' hundred ' + 'and ' + getTeen(teen));
    } else if (ten) {
        console.log(getDigit(hundred) + ' hundred ' + 'and ' + getTeen(ten * 10) + ' ' + getDigit(digit));
    } else {
        console.log(getDigit(hundred) + ' hundred ' + 'and ' + getDigit(digit));
    }
}

function getDigit(digit) {
    switch (digit) {
        case 0: return 'zero'; break;
        case 1: return 'one'; break;
        case 2: return 'two'; break;
        case 3: return 'three'; break;
        case 4: return 'four'; break;
        case 5: return 'five'; break;
        case 6: return 'six'; break;
        case 7: return 'seven'; break;
        case 8: return 'eight'; break;
        case 9: return 'nine'; break;
    }
}
function getTeen(teen) {
    switch (teen) {
        case 10: return 'ten'; break;
        case 11: return 'eleven'; break;
        case 12: return 'twelve'; break;
        case 13: return 'thirteen'; break;
        case 14: return 'fourteen'; break;
        case 15: return 'fifteen'; break;
        case 16: return 'sixteen'; break;
        case 17: return 'seventeen'; break;
        case 18: return 'eightteen'; break;
        case 19: return 'nineteen'; break;
        case 20: return 'twenty'; break;
        case 30: return 'thirty'; break;
        case 40: return 'fourty'; break;
        case 50: return 'fifty'; break;
        case 60: return 'sixty'; break;
        case 70: return 'seventy'; break;
        case 80: return 'eighty'; break;
        case 90: return 'ninety'; break;
    }
}



