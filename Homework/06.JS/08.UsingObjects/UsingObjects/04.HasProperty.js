//Problem 4. Has property
//Write a function that checks if a given object contains a given property.

var obj = { name: 'abc', age: 12 };

console.log(hasProp(obj, 'name'));
console.log(hasProp(obj, 'length'));

function hasProp(obj, prop) {
    var i;    
    for (i in obj) {
        if (i === prop) {
            return true;
        }
    }
    return false;
}