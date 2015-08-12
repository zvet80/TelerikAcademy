function solve() {
    return function (selector) {
        var selected = $(selector)
                        .hide(),

            dropdown = $('<div/>')
                        .addClass('dropdown-list')
                        .append(selected),

            current = $('<div/>')
                        .addClass('current')
                        .attr('data-value', '')
                        .text('Option 1')
                        .appendTo(dropdown)
                        .on('click', function () {
                            var container = $('.options-container');
                            container.css('display', 'inline-block');
                        }),

            optionsConatiner = $('<div/>')
                        .addClass('options-container')
                        .css({
                            'position': 'absolute',
                            'display': 'none'
                        })
                        .appendTo(dropdown)
                        .on('click', function (ev) {
                            var $clicked = $(ev.target);
                            var $divToDisplay = $('.current');
                            $divToDisplay.text($clicked.html());
                            selected.val($clicked.attr('data-value'));

                            var $container = $(this)
                                .css('display', 'none');
                        }),
            options = selected.find('option');

        for (var i = 0; i < options.length; i++) {
            var item = $('<div/>')
                    .addClass('dropdown-item')
                    .attr('data-value', $(options[i]).val())
                    .attr('data-index', i)
                    .text($(options[i]).text())
                    .appendTo(optionsConatiner);
        }

        dropdown.appendTo('body');
    };
}

module.exports = solve;


//.on('click', function () {
//    current.val($(options[i]).val());
//    current.text($(options[i]).text());
//    optionsConatiner.hide();
//    selected.val($(options[i]).val());

//})