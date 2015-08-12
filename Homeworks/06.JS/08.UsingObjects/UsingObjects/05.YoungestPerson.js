//Problem 5. Youngest person
//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.

var people = [
  { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 }];

console.log('youngest person: ' + findMinAge(people));

function findMinAge(arr) {
    var minAge = arr[0].age,
        min = 0,
        i,
        len;
    for (i = 0; i < len; i += 1) {
        if (arr[i].age < minAge) {
            minAge = arr[i].age;
            min = i;
        }
    }
    return arr[min].firstname + ' ' + arr[min].lastname;
}
