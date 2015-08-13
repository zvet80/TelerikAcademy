//Problem 9. Extract e-mails
//Write a function for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.
//Return the emails as array of strings.

var txt = 'zhivkopetrov90@gmail.com  borko_999@mail.bg vercheto nikolova  ani_22222@abv.bg?, aaa  bgerasimov@apnr.eu,  sevimmasarlieva@abv.bg ';

console.log(extractEmails(txt).join(','));

function extractEmails(txt) {
    var i,
    arr = txt.split(/[ ,?]+/),
    len = arr.length,
        result = [];
    for (i = 0; i < len; i++) {
        if (arr[i].trim().indexOf('@')!=-1) {
            result.push(arr[i]);
        }
    }
    return result;
}