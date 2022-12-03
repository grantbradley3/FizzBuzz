public string Divisor(int number)
{
    if(number % 3 == 0)
    {
        answer = "fizz";
    }
    if (number % 5 == 0)
    {
        answer += "buzz";
    }

    return answer;
}