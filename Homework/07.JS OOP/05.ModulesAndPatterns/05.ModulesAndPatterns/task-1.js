function solve() {
    function isValidName(str) {
        if (!/^[A-Z][a-z]*$/.test(str)) {
            throw new Error('error');
        }
    }
    function isValidTitle(str) {
        if (typeof str !== 'string' ||
            str.trim() == '' ||
            /^\s+/.test(str) ||
            /\s+$/.test(str) ||
            /\s{2,}/.test(str)) {
            throw new Error('error');
        }
    }
    function isValidPres(pres) {
        if (pres.length == 0) {
            throw new Error('error');
        }
        pres.forEach(function (title) {
            isValidTitle(title);
        });
    }
    function validScore(results) {
        results.forEach(function (item) {
            if (isNaN(item.score)) {
                throw new Error('error');
            }
        });
    }
    function validId(id, max) {
        if (id != Number(id) || id < 1 || id > max) {
            throw new Error('error');
        }

    }
    var Course = {

        init: function (title, presentations) {
            isValidTitle(title);
            this.title = title;
            isValidPres(presentations);
            this.presentations = presentations;
            this.students = [];
            return this;
        },
        addStudent: function (name) {

            var student,
                names = name.split(' ').trim(),
                id = (this.students.length + 1);
            if (names.length !== 2) {
                throw new Error('error');
            }
            isValidName(names[0]);
            isValidName(names[1]);
            student.firstname = names[0];
            student.lastname = names[1];
            student.id = id;
            student.score = 0;
            this.students.push(student);
            return id;
        },
        getAllStudents: function () {
            return this.students.slice(0);
        },
        submitHomework: function (studentID, homeworkID) {
            this.students.forEach(function (student) {
                validId(homeworkID, this.presentations.length);
                validId(studentID, this.students.length);
                if (student.id === studentID) {
                    student.homeworks++;
                }
            });
            return this;
        },
        pushExamResults: function (results) {
            var i, j, lenR = results.length, lenS = students.length;
            validScore(results);
            for (i = 0; i < lenR; i += 1) {
                for (j = 0; j < lenS; j++) {
                    validId(results[i].StudentID, this.students.length);
                    if (results[i].StudentID == this.students[j].id) {
                        if (this.students[j].score != 0) {
                            throw new Error('error');
                        }
                        else {
                            this.students[j].score = +results[i].score;
                        }
                    }
                    else {
                        throw new Error('error');
                    }

                }
            }
            //results.forEach(function (item) {
            //    if (item.StudentID == this.students[id]) {
            //        if (this.students[id].result!=0) {
            //            throw new Error('error');
            //        }
            //        else {
            //            this.students[id].score = item.score;
            //        }                    
            //    }
            //    else {
            //        throw new Error('error');
            //    }
            //});
            return this;
        },
        getTopStudents: function () {
            this.students.forEach(function (student) {
                student.totalScore = (25 * (student.homeworks / this.presentations.length)) + (0.75 * student.score);
            });
            var sorted = this.students.slice(0);
            sorted.sort(function (a, b) {
                return a.totalScore - b.totalScore;
            });
            return sorted.slice(0, 10);
        }
    };

    return Course;
}


module.exports = solve;