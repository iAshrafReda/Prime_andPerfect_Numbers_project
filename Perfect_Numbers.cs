Console.WriteLine("Enter a number1"); 
   int n1=int.Parse(Console.ReadLine()); 
   Console.WriteLine("Enter a number2"); 
   int n2=int.Parse(Console.ReadLine()); 
   int i, j; 
             
            for (i = n1; i <= n2; i++) 
            { 
                int count = 0; 
                for (j = 1; j <= i; j++) 
                { 
 
                    if (i % j == 0) 
                    { count = count + 1; } 
                } 
 
                if (count <= 2) 
                { Console.WriteLine(i); } 

            } 
            Console.ReadKey();