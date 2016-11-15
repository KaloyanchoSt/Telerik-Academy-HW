function solve(args) {
    var n = args[0];
    var row = 1,
        column = 0,
        i,
        result = "";

    for ( i = 0; i < n; i++) {

        if (row <= n) {
            if (i < n - 1) {
                result += (i + row) + " ";
            } else {
                result += i + row + "\n";
                row++;
                i = -1;
            }
        }
    }
    console.log(result);
}

solve('5');
