//Problem 4. Sort 3 numbers
//Sort 3 real values in descending order.
//Use nested if statements


var a = 5,
    b = -8,
    c = 0;
Sort(a, b, c);

function Sort(a, b, c) {    
    if (!isNaN(a) && !isNaN(b) && !isNaN(c)) {
        if (a > b) {
            if (a > c) {
                if (b > c) {
                    console.log( a, b, c);
                } else {
                    console.log( a, c, b);
                }
            } else {
                console.log( c, a, b);
            }
        }
        else {
            if (b < c) {
                console.log( c, b, a);
            } else {
                if (a < c) {
                    console.log( b, c, a);
                }else {
                    console.log( b, a, c);
                }
            }
        }
    } else {
        throw new Error('not a valid number');
    }
}


