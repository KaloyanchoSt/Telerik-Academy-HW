function Solve(params) {
var numbers = params.slice(1).map(Number),
i,
j,
k,
temp;

for (i = 0; i < numbers.length - 1; i += 1) {
    for (j = i + 1; j < numbers.length; j += 1) {
        if (numbers[i] > numbers[j]) {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}


return numbers.join('\n');
}

var test1 = [
  '10',
  '36', '10', '1', '34', '28', '38', '31', '27', '30', '20'
];
console.log(Solve(test1));

/*
Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position,
find the smallest from the rest, move it at the second position, etc.
Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output
Print the sorted array
Each number should be on a new line
Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests
Input   Output
6
3       1
4       2
1       3
5       4
2       5
6       6
10
36      1
10      10
1       20
34      27
28      28
38      30
31      31
27      34
30      36
20      38
*/
