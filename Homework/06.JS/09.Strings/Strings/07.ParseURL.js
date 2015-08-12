//Problem 7. Parse URL
//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.

var url = 'http:\//telerikacademy.com/Courses/Courses/Details/239';

console.log(parseUrl(url))
function parseUrl(url) {
    var result,
        protocol = url.substring(0, url.indexOf("://")),
        rest = url.substring(url.indexOf("://") + 3),
        server = rest.substring(0, rest.indexOf('/')),
        resource = rest.substring(rest.indexOf('/'));
    result = {
        'protocol': protocol,
        'server': server,
        'resource': resource
    }
    return result;
}