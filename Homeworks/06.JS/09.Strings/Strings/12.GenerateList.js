//Problem 12. Generate list
//Write a function that creates a HTML <ul> using a template for every HTML <li>.
//The source of the list should be an array of elements.
//Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.

var people = [{ name: 'Peter', age: 14 },
    { name: 'Gosho', age: 24 }
];
var tmpl = document.getElementById('list-item').innerHTML;
var peopleList = generateList(people, tmpl);
console.log(peopleList);

function replaceTmpl(person,tmpl) {
    tmpl = tmpl.replace('-{name}-', person.name);
    tmpl = tmpl.replace('-{age}-', person.age);
    return tmpl;
}
function generateList(people,tmpl) {
    var result = '<ul>';
    for (var i = 0; i < people.length; i++) {
        result += '<li>' + replaceTmpl(people[i], tmpl) + '</li>';
    }
    result += '</ul>';
    return result;
}