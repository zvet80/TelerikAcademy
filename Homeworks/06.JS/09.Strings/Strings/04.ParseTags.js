//Problem 4. Parse tags
//You are given a text. Write a function that changes the text in all regions:

var txt = ' We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>AnythinG</lowcase> else.';

console.log(replTag('<mixcase>', replTag('<lowcase>', replTag('<upcase>', txt))));

function replTag(tagO, txt) {
    var i,
        len = txt.length,
        tagC = '</' + tagO.replace('<', '');

    for (i = 0; i < len; i++) {
        if (txt.indexOf(tagO) != -1) {
            var repltxt = txt.substring((txt.indexOf(tagO) + tagO.length), txt.indexOf(tagC));

            txt = txt.replace(txt.substring(txt.indexOf(tagO), (txt.indexOf(tagC) + tagC.length)), txtToReplace(tagO, repltxt));
        }
    }
    return txt;
}

function txtToReplace(tagO, repltxt) {
    switch (tagO) {
        case '<upcase>': return repltxt.toUpperCase(); break;
        case '<lowcase>': return repltxt.toLowerCase(); break;
        case '<mixcase>': return makeMixcase(repltxt); break;
    }
}
function makeMixcase(txt) {
    var i,
        len = txt.length,
        res = '',
        rand;

    for (i = 0; i < len; i++) {
        rand = Math.round(Math.random());
        switch (rand) {
            case 0: res += txt[i].toLowerCase(); break;
            case 1: res += txt[i].toUpperCase(); break;
        }
    }
    return res;
}



