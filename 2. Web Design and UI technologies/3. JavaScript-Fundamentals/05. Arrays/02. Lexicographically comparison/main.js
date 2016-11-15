function Solve(params) {
    var input = params[0].split('\n'),
        firstWord = input[0],
        secondWord = input[1],
        result;

    if (firstWord > secondWord) {
        result = '>';
    } else if (secondWord > firstWord) {
        result = '<';
    } else {
        result = '=';
    }

    console.log(result);
}

Solve(['hello', 'halo']);
