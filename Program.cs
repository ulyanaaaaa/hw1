// Console.Write("Enter first number: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// if (firstNum > secondNum)
// {
//     Console.Write(firstNum+" > "+secondNum);
// }
// else
// {
//     Console.Write(secondNum+" > "+firstNum);
// }



// Console.Write("Enter first number: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter third number: ");
// int thirdNum = Convert.ToInt32(Console.ReadLine());
// if (firstNum > secondNum && firstNum > thirdNum)
//     {
//         Console.Write("Biggest number is: "+firstNum);
//     }
// else if (secondNum > firstNum && secondNum > thirdNum)
//     {
//         Console.Write("Biggest number is:"+secondNum);
//     }
// else Console.Write("Biggest number is: "+thirdNum);



// Console.Write("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.Write("Even number");
// }
// else Console.Write("Not even number");



Console.Write("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int zero = 0;
if (userNumber > zero)
    {
        do 
            {
                zero = zero + 2;
                Console.Write(zero+" ");
            }
        while (userNumber > zero);
    }
else Console.Write("Enter even number");