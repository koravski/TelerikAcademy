/*Problem 2. Lexicographically comparison

 Write a script that compares two char arrays lexicographically (letter by letter).*/

var n = 50,
    m = 6,
    firstArr = randomString(n),
    secondArr = randomString(m),
    length = Math.min(firstArr.length, secondArr.length);

    if (firstArr.length > secondArr.length) {
        console.log('Second array is earlier.');
    }
    else if (firstArr.length == secondArr.length) {
        for (var i = 0; i < length; i++) {
            if (firstArr[i] > secondArr[i]) {
                console.log('Second array is earlier.');
                break;
            }
            else if (firstArr[i] < secondArr[i]) {
                console.log('First array is earlier.');
                break;
            }
            else {
                console.log('Arrays are equal.');
            }
        }
    }
    else {
        console.log('First array is earlier.');
    }

    function randomString(length) {
        var chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXTZabcdefghiklmnopqrstuvwxyz";
        var randomStr = '';
        for (var i = 0; i < length; i++) {
            var rndNum = Math.floor(Math.random() * chars.length);
            randomStr += chars.substring(rndNum, rndNum + 1);
        }

        return randomStr;
    }


