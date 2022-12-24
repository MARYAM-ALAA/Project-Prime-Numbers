using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Please Enter The First Number Of The Range");
                int start = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter The Last Number Of The Range");
                int end = int.Parse(Console.ReadLine());


                {
                    for (int i = start; i <= end; i++)
                    {
                        int count = 0;
                        for (int j = 2; j <= i / 2; j++)
                        {
                            if (i % j == 0)
                            {
                                count++;
                                break;
                            }
                        }
                        if (count == 0 && i != 1)
                            Console.WriteLine(i + " ");
                    }
                }


               


            }
        }



        }


        }
    

