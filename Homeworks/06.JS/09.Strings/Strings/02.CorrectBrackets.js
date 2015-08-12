//Problem 2. Correct brackets
//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b))

var str = '((a+b)/5-d)';

console.log('correct? '+ (countS('(',str)==countS(')',str)));


function countS(char,str) {
    var i,
        len = str.length,
        count=0;
    for (i = 0; i < len; i+=1) {
        if (str[i]==char) {
            count++;
        }
    }
    return count;
}

