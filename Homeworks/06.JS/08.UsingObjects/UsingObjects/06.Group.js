//Problem 6.
//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)

var people = [
  { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 }];

console.log('age: ' + groupBy(people, 'age'));

function groupBy(arr, prop) {
    var grouped = {};
    for (var i in arr) {
        var groupProperty = arr[i][prop];
        if (!grouped.hasOwnProperty(groupProperty)) {
            grouped[groupProperty] = [];
        }
        grouped[groupProperty].push(arr[i]);
    }
    return grouped;
}

//function groupBy(arr, prop) {
//    var grouped = [];
//    for (var i in arr) {
//        if (arr[i].hasOwnProperty(prop)) {
//            grouped.push(arr[i]);
//        }
//    }
//    return grouped;
//}



