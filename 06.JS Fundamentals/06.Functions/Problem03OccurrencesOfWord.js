/*Problem 3. Occurrences of word

 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.*/

function solveTask(text, word, sensitive) {
    var i,
        j,
        caseSens = sensitive || false,
        newStr = text.replace(/\W+/g, ' '),
        words = newStr.split(' '),
        occurrences = 0;

    if (caseSens) {
        for (i = 0; i < words.length; i += 1) {
            if (words[i] === word) {
                occurrences += 1;
            }
        }
    }
    else {
        var lowerCase = word.toLowerCase();

        for (j = 0; j < words.length; j += 1) {
            if (words[i].toLowerCase() == lowerCase) {
                occurrences += 1;
            }
        }
    }

    return occurrences;
}

console.log(solveTask('hello hello hello this is a list of different words that it is', 'hello', true));