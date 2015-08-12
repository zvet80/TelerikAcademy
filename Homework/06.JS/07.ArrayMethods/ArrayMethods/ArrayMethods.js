//Problem 1. Make person
//Write a function for creating persons.
//Each person must have firstname, lastname, age and gender (true is female, false is male)
//    Generate an array with ten person with different names, ages and genders

function Person(fname, lname, age, gender) {
    this.firstname = fname;
    this.lastname = lname;
    this.age = age;
    this.gender = gender;
    this.fullname = function () {
        return this.firstname + ' ' + this.lastname;
    }
}
var people = [
    new Person('Iv', 'Petrova', 12, 'female'),
    new Person('Ivan', 'Petrov', 22, 'male'),
    new Person('Ilian', 'Dimitrov', 82, 'male'),
    new Person('An', 'Petrova', 43, 'female'),
    new Person('Ina', 'Dimitrova', 33, 'female'),
    new Person('Peter', 'Petrov', 2, 'male'),
    new Person('Iva', 'Ivanova', 28, 'female'),
    new Person('Gosho', 'Goshov', 36, 'male'),
    new Person('Ivo', 'Goshov', 56, 'male'),
    new Person('Gosho', 'Ivanov', 24, 'male')
];
people.forEach(function (person) {
    console.log(person);
});

console.log(new Array(20).join('-'));

//Problem 2. People of age
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//    Use only array methods and no regular loops (for, while)

var result = people.every(function (person) {
    return person.age >= 18;
})
console.log(result);

console.log(new Array(20).join('-'));

//Problem 3. Underage people
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach

var underaged = people.filter(function (person) {
    return person.age < 18;
}).forEach(function (person) {
    console.log(person);
})

console.log(new Array(20).join('-'));
//Problem 4. Average age of females
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter

var femalesAvgAge = people.filter(function (person) {
    return person.gender == 'female';
}).reduce(function (sum, person,_,arr) {
    var count = arr.length;
    return (sum + person.age / count);
}, 0);
console.log('femalesAvgAge' + ' ' + femalesAvgAge.toFixed(1));

console.log(new Array(20).join('-'));
//Problem 5. Youngest person
//Write a function that finds the youngest male person in a given array of people and prints his full name
//    Use Array#find

if(!Array.prototype.find){
    Array.prototype.find=function(callback){
        var i,
            len=this.length;
        for (i = 0; i < len; i+1) {
            if(callback(this[i],i,this)){
                return this[i];
            }
        }
        return undefined;
    }
}

var youngest = people.sort(function (p1, p2) {
    return p1.age > p2.age;
}).find(function (person) {
    return person.gender == 'male';
});
console.log(youngest.fullname());

console.log(new Array(20).join('-'));
//Problem 6. Group people
//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce

var groups = people.reduce(function (group, person) {
    if (!group[person.firstname[0]]) {
        group[person.firstname[0]] = [];
    }
    group[person.firstname[0]].push(person);
    return group;
}, {});
console.log(groups);