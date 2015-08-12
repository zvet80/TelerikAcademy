//Problem 2. HTML binding
//Write a function that puts the value of an object into the content/attributes of HTML tags.
//Add the function to the String.prototype


if (!String.prototype.bind) {
    String.prototype.bind = function (str,options) {
        var result='';
        for (var i = 0; i < this.length; i++) {
            
            while (this.indexOf('data-bind-',i) != -1) {
                var placeholder=this.substring(this.indexOf('data-bind-')+11,this.indexOf('=')-1),
                    prop=this.substring(this.indexOf('"',i),)

                if (placeholder=='content') {
                    result += str.substring(i,str.indexOf('>',i)+ options[str.indexOf('"',i)]+/<\/w+/;
                }
                else {
                    this.replace(/'data-bind-'/, '');
                    result+=//w+/+
                }
                
            }
        }
        if ('data-bind-content') {

        }
        return this.replace(/#{(\w+)}/g, function (match, prop) {
            return options[prop] || '';
        });
    }
}
var str = '<div data-bind-content="name"></div>';
console.log(str.bind(str, { name: 'Steven' }));
var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></а>'
str.bind(str, { name: 'Elena', link: 'http:\//telerikacademy.com' });