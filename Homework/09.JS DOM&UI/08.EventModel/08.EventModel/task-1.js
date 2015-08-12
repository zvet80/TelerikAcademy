/* globals $ */

/* 

Create a function that takes an id or DOM element and:

If an id is provided, select the element
Finds all elements with class button or content within the provided element
Change the content of all .button elements with "hide"
When a .button is clicked:
Find the topmost .content element, that is before another .button and:
If the .content is visible:
Hide the .content
Change the content of the .button to "show"
If the .content is hidden:
Show the .content
Change the content of the .button to "hide"
If there isn't a .content element after the clicked .button and before other .button, do nothing
Throws if:
The provided DOM element is non-existant
The id is either not a string or does not select any DOM element
  

*/

function solve() {
    return function (selector) {
        var element;

        if (selector === undefined ||
            selector === null) {
            throw new Error('error');
        }

        if (typeof (selector) == 'string') {
            element = document.getElementById(selector);
        } else {
            element = selector;
        }

        if (!(element instanceof HTMLElement)) {
            throw new Error('error');
        }

        var children = element.childNodes,
                i,
                len = children.length;

        for (i = 0; i < len; i++) {
            var current = children[i];
            if (current.className == 'button') {
                current.innerHTML = 'hide';
                current.addEventListener('click', onBtnClick);
            }
        };

        function onBtnClick(ev) {
            var clicked = ev.target,
                next = clicked.nextElementSibling,
                nextBtn;

            while (next && next.nextElementSibling) {
                if (next.className == 'content') {
                    nextBtn = next.nextElementSibling;
                    while (nextBtn) {
                        if (nextBtn.className == 'button') {
                            changeDisplay(next);
                            break;
                        }
                        nextBtn = nextBtn.nextElementSibling;
                    }
                    break;
                } else {
                    next = next.nextElementSibling;
                }                
            };
            function changeDisplay(el) {
                if (el.style.display == 'none') {
                    el.style.display = '';
                    clicked.innerHTML = 'hide';
                } else {
                    el.style.display = 'none';
                    clicked.innerHTML = 'show';
                };
            };

        };


    };
}

module.exports = solve;