/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName`, `age` and `marks` properties
        *   `marks` is an array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve() {
    return function (students) {
        var first = _.chain(students)
         .map(function (student) {
             student.fullName = student.firstName + ' ' + student.lastName;

             student.avgMark = (_.reduce(student.marks, function (sum, mark) {
                 return sum + mark;
             }, 0)) / student.marks.length;

             return student;
         }).sortBy(function (student) {
             return -student.avgMark;
         }).first()
           .value();

        console.log(first.fullName + ' has an average score of ' + first.avgMark);
    };
}

module.exports = solve;
