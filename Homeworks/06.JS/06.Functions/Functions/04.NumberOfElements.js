//Problem 4. Number of elements
//Write a function to count the number of div elements on the web page

countDiv();

function countDiv() {
   var count = document.getElementsByTagName('div').length
    console.log(count);
}