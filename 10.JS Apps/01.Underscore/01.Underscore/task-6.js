/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve() {
    return function (books) {
        var sorted = _.chain(books)
            .countBy(function (book) {
                var fullName = book.author.firstName + ' ' + book.author.lastName;
                return fullName;
            })
            .pairs()
            .map(function (pair) {
                pair.fullName = pair[0];
                pair.count = pair[1];
                return pair;
            })
            .sortBy('fullName')
            .sortBy(function (pair) {
                return -pair.count;
            })
            .value();

        _.chain(sorted)
         .filter(function (pair) {
             return pair.count == sorted[0].count;
         })
         .each(function (pair) {
             console.log(pair.fullName);
         });

        //_.chain(sorted)
        // .where({count: _.max(sorted,function(pair){
                    //         return pair.count;
                    //     }).count
        // })
        // .each(function (pair) {
        //     console.log(pair.fullName);
        // });
    };
}
var books = [{
    title: 'Spam is everywhere',
    author: {
        firstName: 'Spamim',
        lastName: 'Mnogo'
    }
}];
solve()(books);
module.exports = solve;
