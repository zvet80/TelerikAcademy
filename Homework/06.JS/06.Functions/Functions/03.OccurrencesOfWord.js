//Problem 3. Occurrences of word
//Write a function that finds all the occurrences of word in a text.
//The search can be case sensitive or case insensitive.
//Use function overloading.

var txt = 'word Word WORD';
console.log(countWords(txt, 'word', true));
console.log(countWords(txt, 'word', false));

function countWords(text, word, isCaseSensitive) {
    var i,
        count = 0,
        txt = [];
    if (!isCaseSensitive) {
        text = text.toLowerCase();
        word.toLowerCase();
    }
    txt = text.split(' ');
    for (i = 0; i < txt.length; i += 1) {
        if (word === txt[i]) {
            count++;
        }
    }
    return count;
}