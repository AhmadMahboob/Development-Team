using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Concepts
{
    class Program
    {
        static void Main(string[] args)
        { /*
            Console.Write(" Enter yor name : ");
            string fn = Console.ReadLine();
            Console.WriteLine(" Hello, {0}", fn);

            Console.Write(" a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" b = ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" {0} + {1} = {2}", a, b, a + b);
            Console.WriteLine(" {0} * {1} = {2} ", a, b, a * b);
          

            int i;
            bool parseSucess = Int32.TryParse(Console.ReadLine(), out i);


            Console.WriteLine(parseSucess ? " The square of the number is " + i*i  : "invaliad number");
            Console.ReadLine();
            

            a:     Console.Write("\n Enter any positive number : ");
            Int64 num = int.Parse(Console.ReadLine());

            int Divisor = 2;
            int maxDivisor = (int)Math.Sqrt(num);

            bool prime = true;

            while (prime && (Divisor <= maxDivisor))
            {
                if (num % Divisor == 0)
                {
                    prime = false;
                }
                Divisor++;
            }

     // finding Facturial of the number 
            Int64 fact = 1;

            while (true)
            {
                if (num < 1)
                {
                    break;
                }
                fact = fact * num;

                num--;
            }




            Console.WriteLine("\n\n\a -> Prime ?     : {0,8}", prime);
            Console.WriteLine("\n -> Factorail ! : {0,8}", fact);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\n Do you wana enter a new number y/n");
            string choice = "";
            choice = Console.ReadLine();

            if (choice == "Y" || choice == "y")
            {
                goto a;
            }

            else
                Console.ReadLine();
                
    
    // ARRAY

            int[] number = new int[5];

            number[0] = 10;
            number[1] = 20;
            number[2] = 30;
            number[3] = 40;
            number[4] = 50;

            foreach(int i in number )
            {
                Console.WriteLine("number  : {0} ",i);
            }

            Console.WriteLine(number.Length);
;

        //OR

            int[] number1 =new  int [] { 1, 2, 2, 4, 4,66 };

            foreach(int number in number1)
            {
                
                Console.WriteLine("\n\anumber  : " + number);
            }

    
        //OR

            string[] name = new string[] { "ahmad ", "is ", "a ", "good ", "boy " };

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }

        
            //OR

            string zig = " i love u";
            char[] CharArray = zig.ToCharArray();

            Array.Reverse(CharArray);

            foreach (char word in CharArray)
            {
                Console.Write(word);
            }

            Console.ReadLine();
            

        // READ IN ARRAY
            double[] i = new double[5];

            Console.Write("Enter any 5 number : \n");

            for (int c = 0; c < i.Length; c++)
            {
                Console.Write("\n \a   " + "(" +(c+1)+ ")" + " ");
                i[c] = double.Parse(Console.ReadLine());
               }

               

            int[] i = { 1, 2, 3, 4 };

            Array.Reverse(i);

            foreach (int n in i)
            {
                Console.WriteLine(n);

            }
            ;
            
            

        //Tow Dimantion Array

            int[,] a =
            {
            //2,Row          4,Column
                { 1,3,4,5,6 },
                { 2,3,4,4,4 },
            };

            Console.WriteLine(" \n\n -> Two Dimention Array \n\n Value in Array[1,2] :  "+ a[1,2]);

            Console.WriteLine("\n\n\a Rows     = " + a.GetLength(0) +  
                              "\n Columns  = " + a.GetLength(1));


            // Printing values

            for (int m = 0; m < a.GetLength(0); m++)
            {
                Console.Write("\n\n Values in Row {0} : ", (m + 1));

                for (int n = 0; n < a.GetLength(1); n++)
                {
                    Console.Write( a[m, n]);
                }
                
            }
         
       // Matrix


            Console.Write("\n Enter the number of Rows : ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("\n Enter the number of Column : ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[m, n];



            for (int m1 = 0; m1 < array.GetLength(0); m1++)
            {
                Console.WriteLine("\n\n Enter values in Row {0}  \n", (m1 + 1));

                for (int n1 = 0; n1 < array.GetLength(1); n1++)
                {
                    Console.Write("  Column {0} : ", n1 + 1);
                    array[m1, n1] = int.Parse(Console.ReadLine());
                }
            }
            // To Show

            Console.Write("\n\n\n Your Matrix is :- \n\n");
            for (int m1 = 0; m1 < array.GetLength(0 ); m1++)
            { 
                Console.Write("\n  [  ");

                for (int n1 = 0; n1 < array.GetLength(1); n1++)
                {
                    Console.Write("{0,-10} " ,array[m1,n1]);
                    
                }
            Console.Write("  ] ");

        }

            Console.WriteLine("\n\n\n\a");



    /*

       //jagged Array

            int [][] jaggedarray= new int[2] [] ;
            jaggedarray[0] = new int[2];
            jaggedarray[1] = new int[3];



            int[][] myjaggedarray =
            {
                new int [] {4,5,5},
                new int [] {43,4},
                new int [] {33,4}
            };

    

            int a = 5;
            char[] array = { 'a', 'h', 'm', 'a', 'd' };


            for (int i = 0; i <array.Length ; i++)
            {
                Console.Write(array[i]);

            }

                Console.ReadLine();
                


            int[][] ArrayOfArray = new int[3][];
            ArrayOfArray[0] = new int[3];
            ArrayOfArray[1] = new int[] { 23, 34, 43 };


            ArrayOfArray[2] = new int[] { 22, 3, 4, };




            ArrayOfArray[0]= new int[]{ 22,33,34,4};

            for (int i = 0; i < ArrayOfArray[2].Length; i++)
            {


                Console.WriteLine(ArrayOfArray[2][i]);
            }

            

          // First program

            Console.Write("\n Enter Your First Name : ");
            string Fn = Console.ReadLine();
            Console.Write("\n Enter Your Second Name : ");
            string Sn = Console.ReadLine();
            Console.Write("\n Enter Your Year of Birth : ");
            int YoB = int.Parse(Console.ReadLine());

            
            String Year = DateTime.Now.Year.ToString();

            int Age = Convert.ToInt16(Year) - YoB;

            Console.WriteLine("\n Hello, {0} {1} . How you Doing \n Your Calculated Age is {2}", Fn, Sn, Age);

            Console.ReadLine();


           

            Decimal N1 = 1000000000000000;
            string number = N1.ToString("E1");


            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ur-PK");

            Console.WriteLine("{0:(0#) ### ## ##}", 29342525);


            Console.WriteLine(number);
            Console.ReadLine();
            */


            Console.WriteLine("How Are You");
            Console.WriteLine("Enter Your First Name\n");
            string first = Console.ReadLine();
            Console.WriteLine("Enter Your Second Name\n");
            string second = Console.ReadLine();
            //Console.Write("\a\aHello Mister" + first + " " + second + " " + "How you Doing");
            // Console.ReadLine();
            //Console.Write("How Are You : {0} {1}",first,second);
            // Console.ReadLine();
            Console.Write("\a\ayoure First Name is=" + first);

        }
    }
}
