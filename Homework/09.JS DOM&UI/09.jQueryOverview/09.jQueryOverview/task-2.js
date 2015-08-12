/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function (selector) {

        var element;

        if (typeof (selector) !== 'string') {
            throw new Error('error');
        }

        element = $(selector);

        if (!element.length) {
            throw new Error('error');
        }

        var childrenBtn = element.children('.button')
                                 .text('hide')
                                 .on('click', onBtnClick);

        function onBtnClick() {
            var $this = $(this),
                nextCnt = $this.nextAll('.content').first(),
                nextBtn = nextCnt.nextAll('.button').first();

            if (nextCnt.length && nextBtn.length) {
                if (nextCnt.css('display') == 'none') {
                    nextCnt.css('display', '');
                    $this.text('hide');
                } else {
                    nextCnt.css('display', 'none');
                    $this.text('show');
                };
            }
        };
    };
};

module.exports = solve;