/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example
var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');
var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)
var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');
div.content = 'Hello, world!';
var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');
var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);
console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
    var domElement = (function () {
        function isValidString(str) {
            if (typeof str !== 'string' ||
                !/^[a-z\d]+$/i.test(str)) {
                throw new Error('error');
            }
        }
        function isValidAttribute(str) {
            if (typeof str !== 'string' ||
                !/^[a-z\d\-]+$/i.test(str)) {
                throw new Error('error');
            }
        }
        function sortAttributes(attributes) {
            var sorted = attributes.slice(0);
            sorted.sort(function (a, b) {
                return a.name > b.name;
            });
            return sorted;
        }

        var domElement = {
            init: function (type) {
                this.type = type;
                this.content = '';
                this.parent;
                this.children = [];
                this.attributes = [];
                return this;
            },
            set type(value) {
                isValidString(value);
                this._type = value;
            },
            get type() {
                return this._type;
            },
            set content(value) {
                if (typeof value !== 'string') {
                    throw new Error('error');
                }
                this._content = value;
            },
            get content() {
                return this._content;
            },
            set attributes(value) {
                this._attributes = value;
            },
            get attributes() {
                return this._attributes;
            },
            set parent(value) {
                this._parent = value;
            },
            get parent() {
                return this._parent;
            },
            set children(value) {
                this._children = value;
            },
            get children() {
                return this._children;
            },
            appendChild: function (child) {
                if (typeof child !== 'string') {
                    child.parent = this;
                }
                this.children.push(child);
                return this;
            },
            addAttribute: function (name, value) {
                isValidAttribute(name);
                var attribute = { name: name, value: value },
                    index = this.attributes.map(function (item) { return item.name; })
                           .indexOf(name);
                if (index !== -1) {
                    this.attributes[index].value = value;
                } else {
                    this.attributes.push(attribute);
                }
                return this;
            },
            removeAttribute: function (attributeName) {
                var removeIndex = this.attributes.map(function (item) { return item.name; })
                           .indexOf(attributeName);
                if (removeIndex == -1) {
                    throw new Error('Error');
                } else {
                    for (var i = 0; i < this.attributes.length; i++) {
                        this.attributes.splice(removeIndex, 1);
                    }
                }
                return this;
            },
            get innerHTML() {
                var result = '',
                    child,
                    sortedAttributes = sortAttributes(this.attributes),
                    element,
                    i,
                    lenS = sortedAttributes.length,
                    len = this.children.length;

                result += '<' + this.type;

                if (lenS) {
                    for (i = 0; i < lenS; i++) {
                        element = sortedAttributes[i];
                        result += ' ' + element.name + '="' + element.value + '"';
                    }
                }
                result += '>';

                if (len) {
                    for (i = 0; i < len; i++) {
                        child = this.children[i];
                        if (typeof child === 'string') {
                            result += child;
                        } else {
                            result += child.innerHTML;
                        }
                    }
                } else {
                    result += this.content;
                }
                result += '</' + this.type + '>';

                return result;
            }
        };
        return domElement;
    }());
    return domElement;

}

module.exports = solve;
