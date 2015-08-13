/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

function solve() {

    return function (element, contents) {
        var temp,
            dFrag,
            newDiv,
            divToAdd;
        if (element == null ||
            contents == null) {
            throw new Error('error');
        }

        if ((typeof (element) != 'string') &&
            !(element instanceof HTMLElement)) {
            throw new Error('error');
        }

        for (var i = 0; i < contents.length; i++) {
            if (typeof (contents[i]) != 'string' &&
                typeof (contents[i]) != 'number') {
                throw new Error('error');
            }
        }

        if (typeof (element) == 'string') {
            temp = document.getElementById(element);
        }
        else {
            temp = element;
        }

        temp.innerHTML = '';

        newDiv = document.createElement('div');
        dFrag = document.createDocumentFragment();

        for (var i = 0; i < contents.length; i++) {
            divToAdd = newDiv.cloneNode(true);
            divToAdd.innerHTML = contents[i];
            dFrag.appendChild(divToAdd);
        }
        temp.appendChild(dFrag);
    };
};