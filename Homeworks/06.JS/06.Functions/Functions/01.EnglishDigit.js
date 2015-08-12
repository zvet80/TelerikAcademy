//Problem 1. English digit
//Write a function that returns the last digit of given integer as an English word.

var a = 5986;
    
console.log(getLastDigit(a));


function getLastDigit(a)
{
	var digit = a % 10;
switch (digit)
{
	case 1: return "one"; break;
	case 2: return "two"; break;
	case 3: return "three"; break;
	case 4: return "four"; break;
	case 5: return "five"; break;
	case 6: return "six"; break;
	case 7: return "seven"; break;
	case 8: return "eight"; break;
	case 9: return "nine"; break;
	case 0: return "zero"; break;
	default: return "not a digit";
		break;
}
}