function Solve(params) {
    var i, j, len, frequentNum, currNum,
        count = 1,
        maxCount = 1,
        numbers = params.slice(1).map(Number);

    for (i = 0, len = numbers.length; i < len; i += 1) {
        currNum = numbers[i];
        for (j = i + 1; j < len; j += 1) {
            if (currNum === numbers[j]) {
              count += 1;
              if (count > maxCount) {
                maxCount = count;
                frequentNum = currNum;
              }
            }
        }
        count = 1;
    }
    return frequentNum + ' (' + maxCount + ' times)';
}

//console.log(Solve(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']));
var test1 = [
  '13',
  '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3'
];
console.log(Solve(test1));

/*
Write a program that finds the most frequent number in an array of N elements.
Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output
Print the most frequent number and how many time it is repeated
Output should be REPEATING_NUMBER (REPEATED_TIMES times)
Constraints
1 <= N <= 1024
0 <= each number in the array <= 10000
There will be only one most frequent number
Time limit: 0.1s
Memory limit: 16MB
Sample tests
Input   Output
13      4 (5 times)
4
1
1
4
2
3
4
4
1
2
4
9
3
*/
