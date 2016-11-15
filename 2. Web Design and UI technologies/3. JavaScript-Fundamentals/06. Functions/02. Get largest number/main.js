function GetLargestNumber(args) {
  var numbers = args[0].split(' ');
  var firstNum = +numbers[0],
      secondNum = +numbers[1],
      thirdNum = +numbers[2];

  if (thirdNum > GetMax(firstNum, secondNum)) {
    return thirdNum;
  } else {
    return GetMax(firstNum, secondNum);
  }

  function GetMax(first, second) {
    if (first > second) {
      return first;
    } else {
      return second;
    }
  }
}

console.log(GetLargestNumber(['8 3 6']));
console.log(GetLargestNumber(['7 19 19']));
