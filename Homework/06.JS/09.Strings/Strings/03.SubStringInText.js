//Problem 3. Sub-string in text
//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

var txt = 'The text is as follows: We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.',
    str = 'in';

console.log(countS(str, txt));

function countS(str, txt) {
    var i,
        len = txt.length,
        count = 0
        txt=txt.toLowerCase();
    for (i = 0; i < len; i += 1) {
        if (txt.indexOf(str, i) != -1) {
            count++;
            i = txt.indexOf(str, i);
        }
    }
    return count;
}