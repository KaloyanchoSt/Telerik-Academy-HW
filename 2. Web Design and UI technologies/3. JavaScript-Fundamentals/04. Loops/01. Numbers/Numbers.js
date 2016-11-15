function solve(args) {
    var n = +args[0],
        res = '';
    for (var i = 1; i <= n; i++) {
       	res+=i+' ';
    }
    console.log(res);
}

solve('5');
