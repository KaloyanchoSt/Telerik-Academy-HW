function PrimeCheck (args) {
  var n = +args[0];
  
  if (n <= 1) {
  console.log("false");
  }
  else {
    var primeCount = 0;
      for (var i = 1; i <= n; i++) {
        if (n % i === 0) {
          primeCount++;
        }
      }
      if (primeCount > 2) {
        console.log("false");
      }
      else {
        console.log("true");
      }
  }
}