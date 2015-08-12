function solve() {
    return function () {
        $.fn.listview = function (data) {
            var $this = $(this),
                tmplStr = $("#" + $this.attr('data-template')).html(),
                template = handlebars.compile(tmplStr),
                i,
                len = data.length;

            for (i = 0; i < len; i += 1) {
                $this.append(template(data[i]));
            }

            return this;
        };
    };
}

module.exports = solve;