/** Problem 3. Typeof variables
 Try typeof on all variables you created.
 */

var arr = [1, 2, 3, 4, 5, 6, 7];
var boolean = true;
var floatingPoint = 5.6;
var integer = 6;
var obj = {};
var regEp = /1-9\g/;
var str = 'Hello World!';
var func = function () {
    return;
};
var nullValue = null;
var undefine = undefined;

var allLiterals = [arr, boolean, floatingPoint, integer, obj,regEp, str,func(),nullValue,undefine];

for (var literal in allLiterals) {
    console.log(typeof(allLiterals[literal]));
}