//Problem 8. Replace tags
//Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

var txt = '<p>Please visit <a href="http:\//academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

console.log(replaceTags(txt));

function replaceTags(txt) {
    var i,
        len = txt.length;

    for (i = 0; i < len; i++) {
        txt = txt.replace('<a href=\"', '[URL=')
                 .replace('</a>', '[/URL]')
                 .replace('">', ']');
    }
    return txt;
}