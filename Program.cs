using System;

namespace Divide_and_Conquer_Problem_Two {
    class Program {
        static void Main(string[] args) {
            int x = 0;             int[] Sorted_List = new int[] { -1,0,2,3,4,5,6,7,8,9,10 }; //Sample List             int n = Sorted_List.Length / 2;             int i = 1;
            while (Sorted_List[n - 1] != x) { //Find if 0 exists and pos of 0 if so
                if (Sorted_List[Sorted_List.Length - 1] <= 0) {
                    break;
                }
                if ((Sorted_List[n - 1] < 0 && Sorted_List[n] > 0) || Sorted_List[0] > 0) {
                    Console.WriteLine("No zero detected");
                    break;
                }else if (Sorted_List[n - 1] > x) {
                    n -= (int)(Math.Floor(n / 2f));
                }else {
                    n += (int)(Math.Ceiling(n / 2f));
                    if (n > Sorted_List.Length) { 
                        n = Sorted_List.Length;
                    }
                }
                i++;             }
            Console.WriteLine("Initial binary search complete");
            int Base = n;
            if (Sorted_List[Base - 1] == 0) {
                if (n != Sorted_List.Length) {
                    while (Sorted_List[n] - Sorted_List[n - 1] <= 1) {
                        Console.WriteLine("thingy: " + (Sorted_List[n - 1]));
                        if (Sorted_List[n - 1] == Sorted_List[n]) { //for same consecutive numbers
                           Base++;
                           n++;
                        }else if (Sorted_List[n - 1] != n - Base) { // If not right value
                            n -= (int)(Math.Floor(n / 2f));
                        }else {
                            n += (int)(Math.Ceiling(n / 2f));
                            if (n >= Sorted_List.Length) { 
                                n = Sorted_List.Length;
                                break;
                            }
                        }
                        i++;
                    }
                }
            }else if (Sorted_List[Sorted_List.Length - 1] == 0) {
                n = 1;
            }else {
                n = -1; 
            }


            //FINAL ANSWER & SHIT
            if (n == -1 || Sorted_List[Sorted_List.Length - 1] < 0) {
                Console.WriteLine("Answer: 0");
            }else if (Sorted_List[Sorted_List.Length - 1] == 0) {
                Console.WriteLine("Answer: 1");
            }else {
                Console.WriteLine("Answer: " + (Sorted_List[n - 1] + 1));
            }             Console.WriteLine("Found in " + i + " cycles!");
        }
    }
}
