//Problem 3. Typeof variables
//Try typeof on all variables you created.

var string = 'string';
var int = 255;
var float = 25.5;
var arr = [1, 2, 3];
var object = {course: 'JS', part: 1};
var boolean = true;
var nullValue = null;
var undefinedValue = undefined;

var variables = [string, int, float, arr, object, boolean, nullValue, undefinedValue];

for (var i = 0; i < variables.length; i++) {
    console.log('Type is:', typeof (variables[i]));
}

