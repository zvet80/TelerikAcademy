//Problem 6. Extract text from HTML
//Write a function that extracts the content of a html page given as text.
//The function should return anything that is in a tag, without the tags.
var txt = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

console.log(extractFromHTML(txt));

function extractFromHTML(txt) {
    var i,
        len = txt.length
        result='';
    for (i = 0; i < len; i++) {
        if (txt[i]==='<') {
            i = txt.indexOf('>', i);
        } else {
            result += txt[i];
        }
    }
    return result;

}