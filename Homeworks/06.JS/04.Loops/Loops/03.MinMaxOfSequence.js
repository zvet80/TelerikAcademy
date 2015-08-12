//Problem 3. Min/Max of sequence
//Write a script that finds the max and min number from a sequence of numbers.

var seq = [-3, -9, -5, -89, -301],
    min = Number.MAX_VALUE,
    max = Number.MIN_VALUE;

for(var i = 0; i < seq.length; i++) {
    if (seq[i] < min) {
        min = seq[i];
    }
    if (seq[i] > max) {
        max = seq[i];
    }
}
console.log('min= ' + min + ' ' + 'max= ' + max);