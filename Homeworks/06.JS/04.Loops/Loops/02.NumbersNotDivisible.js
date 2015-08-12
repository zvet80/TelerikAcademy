//Problem 2. Numbers not divisible
//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var n = 43;
for (var i = 1; i <= n; i++) {
	if ((i % 3) || (i % 7)) {
		console.log(i);
	}
}