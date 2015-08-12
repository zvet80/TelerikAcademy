//Problem 10. Find palindromes
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

var txt = 'Write a program abcba that extracts from a given text all palindromes, e.g. "aBBA", "lamal", "exe".';

console.log(findPals(txt).join(','));

function findPals(txt) {
    var i, j, isPal = true,
    txt = txt.split(/[ ,.!?;"']+/),
    len = txt.length,
    result = [];
    for (i = 0; i < len; i++) {
        if (txt[i].length > 1) {
            for (j = 0; j < Math.floor(txt[i].length / 2) ; j++) {
                if (txt[i][j].toLowerCase() != txt[i][txt[i].length - 1 - j].toLowerCase()) {
                    isPal = false;
                    break;
                }
            }
            if (isPal) {
                result.push(txt[i]);
            }
            isPal = true;
        }
    }
    return result;
}