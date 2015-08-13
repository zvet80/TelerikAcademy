//Problem 1. Format with placeholders
//    Write a function that formats a string. The function should have placeholders, as shown in the example
//    Add the function to the String.prototype

if (!String.prototype.format) {
    String.prototype.format = function (options) {
        
        return this.replace(/#{(\w+)}/g,function(match,prop){
            return options[prop] || '';
        });
    }
}
var people = { name: 'John', age: 13 },
str = 'My name is #{name} and I am #{age}-years-old';
console.log(str.format(people));
var options = { name: 'John' };
console.log('Hello, there! Are you #{name}?'.format(options));