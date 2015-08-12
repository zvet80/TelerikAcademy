//Problem 2. Remove elements
//Write a function that removes all elements with a given value.
//Attach it to the array type.
//Read about prototype and how to attach methods.

Array.prototype.remove = function (value) {
    var i,
        len = this.length;
    for (i = 0; i < len; i+=1) {
        if (this[i] === value) {
            this.splice(i, 1);
            i -= 1;
        }
    }
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
arr.remove(1);
console.log(arr);