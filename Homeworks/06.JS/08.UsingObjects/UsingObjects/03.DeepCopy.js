//Problem 3. Deep copy
//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

var obj = { name: 'abc', age: 12 },
    num = 5,
    copy,
    prop;

console.log(deepCopy(num));
copy = deepCopy(obj);
for (prop in copy) {
    console.log(prop + ':' + copy[prop]);
}

function deepCopy(obj) {
    var copy = {},
        i;
    if (typeof obj === 'object') {
        for (i in obj) {
            copy[i] = deepCopy(obj[i]);
        }
        return copy;
    } else {
        return obj;
    }
}