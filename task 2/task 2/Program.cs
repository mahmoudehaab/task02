using System.Drawing;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            char ch;

            do
            {
                Console.WriteLine("P - Print numbers\nA - Add a number\nM - Display mean of the" +
                    " numbers\nS - Display the smallest number\n" +
                    "L - Display the largest number\nQ - Quit\nf - search numbers\nc - clear numbers");
                Console.WriteLine("=============================================");
                Console.Write("enter your choice : ");
                ch = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine();

                switch (ch)
                {
                    case 'p':

                        if (list.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty \n");
                            break;
                        }
                        else
                            Console.Write("[");
                        {
                            for (int i = 0; i < list.Count; i++)
                                Console.Write(" " + list[i] + " ");
                        }
                        Console.WriteLine("] \n");
                        break;

                    case 'a':

                        Console.Write("enter the number to add : ");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        /********* bonus ******************/
                        if (list.Contains(num))
                        {
                            Console.WriteLine("this number is already exists \n");
                            break;
                        }

                        list.Add(num);
                        Console.WriteLine(num + " is added \n");
                        break;

                    case 'm':

                        if (list.Count == 0)
                            Console.WriteLine("unable to calculate the mean - no data \n");
                        else
                        {
                            int l = 0;
                            int sum = 0;
                            for (int i = 0; i < list.Count; i++)
                            {
                                sum += list[i];
                                l++;
                            }
                            int mean = sum / l;
                            Console.WriteLine("the mean is : " + mean + "\n");
                        }
                        break;

                    case 's':

                        if (list.Count == 0)
                            Console.WriteLine("Unable to determine the smallest number - list is empty \n");
                        else
                        {
                            int smallest = list[0];
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] < smallest)
                                    smallest = list[i];
                            }
                            Console.WriteLine("the smallest number is " + smallest + "\n");
                        }

                        break;

                    case 'l':
                        if (list.Count == 0)
                            Console.WriteLine("Unable to determine the largest number - list is empty \n");
                        else
                        {
                            int largest = list[0];
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] > largest)
                                    largest = list[i];
                            }
                            Console.WriteLine("the largest number is " + largest + "\n");
                        }
                        break;

                    case 'q':
                        Console.WriteLine("goodBye \n");
                        break;

                    /* additional function */

                    case 'f':
                        if (list.Count == 0)
                            Console.WriteLine("list is empty \n");
                        else
                        {
                            Console.Write("enter a number you search for : ");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("the number " + x + " found in index : " + list.IndexOf(x) + "\n");
                        }
                        break;

                    case 'c':
                        list.Clear();
                        Console.WriteLine("the list is empty now \n");
                        break;

                    default:
                        Console.WriteLine("unknown selection, please try again \n");
                        break;


                }


            } while (ch != 'q');

        }
    }
}
