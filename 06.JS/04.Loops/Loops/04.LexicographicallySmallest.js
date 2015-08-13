//Problem 4. Lexicographically smallest
//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

LexMinMax(document);
LexMinMax(window);
LexMinMax(navigator);

function LexMinMax(where) {
    var smallest = 'zzz',
        largest = '';

    for (var prop in where) {
        if (prop < smallest) {
            smallest = prop;
        }
        if (prop > largest) {
            largest = prop;
        }
    }
    return console.log('smallest= ' + smallest + ' ' + 'largest= ' + largest);
}