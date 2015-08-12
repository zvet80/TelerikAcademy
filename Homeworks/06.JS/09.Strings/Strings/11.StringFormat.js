//Problem 11. String format
//Write a function that formats a string using placeholders.
//The function should work with up to 30 placeholders and all types.

var str1 = stringFormat('Hello {0}!', 'Peter'),
    frmt = '{0}, {1}, {0} text {2}'
    str2 = stringFormat(frmt, 1, 'Pesho', 'Gosho');

console.log(str1);
console.log(str2);

function stringFormat() {
    var i,
        len = arguments.length,
        txt = arguments[0],
        placeholder;

    for (i = 0; i < len; i++) {
        placeholder = '{' + i + '}';
        while (txt.indexOf(placeholder) != -1) {
            txt = txt.replace(placeholder, arguments[i + 1]);
        }
    }
    return txt;
}