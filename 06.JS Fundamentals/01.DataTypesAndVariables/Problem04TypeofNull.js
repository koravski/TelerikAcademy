//Problem 4. Typeof null
//Create null, undefined variables and try typeof on them.

var nullValue = null;
var undefinedValue = undefined;

var variables = [nullValue, undefinedValue];

for (var i = 0; i < variables.length; i++) {
    console.log('Type is:', typeof (variables[i]));
}


