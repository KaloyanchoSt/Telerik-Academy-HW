function solve(args) {
    var i,
        n = +args[0],
        numbers = args[1].split(' '),
        x = +args[2],
        count = 0,
        len = numbers.length;

    for (i = 0; i < len; i += 1) {
        if (+numbers[i] === x) {
            count++;
        }
    }

    console.log(count);
}

solve([ '8', '28 6 21 6 -7856 73 73 -56', '73' ] );

/*
Write a method that counts how many times given number appears in a given array.
Write a test program to check if the method is working correctly.
Input
On the first line you will receive a number N - the size of the array
On the second line you will receive N numbers separated by spaces - the numbers in the array
On the third line you will receive a number X
Output
Print how many times the number X appears in the array
Constraints
1 <= N <= 1024
Time limit: 0.2s
Memory limit: 16MB
Sample tests
Input                       Output
8
28 6 21 6 -7856 73 73 -56   2
73
*/
