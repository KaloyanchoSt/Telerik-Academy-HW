/** Problem 4. Typeof null
 Create null, undefined variables and try typeof on them.
 */

var nullValue = null;
var undef; //undefined;
var anotherUndef; //undefined;

var values = [nullValue, undef, anotherUndef];

for (var value in values) {
    console.log(typeof(values[value]));
}