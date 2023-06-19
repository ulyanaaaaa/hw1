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