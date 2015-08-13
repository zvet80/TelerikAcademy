//var books = [
//    { title: 'book1', author: 'author1', isbn: 12563, category: 'drama' },
//    { title: 'book2', author: 'author2', isbn: 12561, category: 'fun' },
//    { title: 'book3', author: 'author3', isbn: 12560, category: 'adventure' }
//],
//categories = ['drama', 'fun', 'crimi', 'adventure', 'tech'];
//console.log(solve());
function solve() {
    var library = (function () {
        var books = [];
        var categories = [];
        function listBooks(option) {
            var list = [];
            if (arguments.length > 0) {
                for (var prop in option) {
                    return list=books.filter(function (book) {
                        return book[prop] === option[prop];
                    }).sort(function (b1, b2) {
                        return b1.ID > b2.ID;
                    });
                }
            }
            return books;
        }

        function addBook(book) {
            if (books.some(function (item) {
                return item.title === book.title ||
                       item.isbn === book.isbn;
            })) {
                throw new Error('error');
            }
            if (book.title.length < 2 || book.title.length > 100) {
                throw new Error('error');
            }
            if (book.author === '') {
                throw new Error('error');
            }
            if ((book.isbn.length !== 10 && book.isbn.length !== 13) || book.isbn.split('').every(function (item) {
                    return isNaN(item);
            })) {
                throw new Error('error');
            }
            if (!categories.some(function (item) {
                return item === book.category;
            })) {
                addCategory(book.category);
            }

            book.ID = books.length + 1;
            books.push(book);

            return book;
        }
        function addCategory(category) {
            category.ID = categories.length + 1;
            if (category.length < 2 || category.length > 100) {
                throw new Error('error');
            }
            categories.push(category);
        }

        function listCategories() {
            categories = categories.sort(function (c1, c2) {
                return c1.ID - c2.ID;
            })
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;