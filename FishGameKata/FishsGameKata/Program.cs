using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishsGameKata
{
    public class Program
    {
        static void Main(string[] args)
        {
            //const int maxnum = 999999999;
            // GameFish game = new GameFish();
            //string word = "11112222";
            //int numVal = Int32.Parse(word);
            string word = "111111111111111111112222222222";
            int i = fish(word);
           // Console.WriteLine(i);
            //Console.ReadLine();
            Console.WriteLine(sum(word));
            Console.ReadKey();
           // int s =SUM(numval);
            //  int sum = numVal.S 
            // Console.WriteLine(numVal);
            //Console.ReadKey();
            // int[] tab = game.RemplirTab(word);
            //var integrNum = word
            //    .Split(delimiters"");
            //    .Where (stringnumber => Convert.ToInt32(stringnumber)<= maxnum)
            //  .Select(stringnumber => Convert.ToInt32(stringnumber));
            //Console.WriteLine(integrNum.Sum());
            //Console.ReadKey();
            //for (int i = 0; i < word.Length; i++)
            //{
            //    tab[i] = Int32.Parse(word[i]);
            //        int.Parse(word[i].GetHashCode(i, i + 1));
            // Console.WriteLine(integrNum);
            //     Console.ReadKey();
        }

    
            public static int fish(string shoal)
            {
                int s = sum(shoal);
                //int a;
            return s / 4;
                
                  
            }
            public static int sum(string shoal)
            {


                if (shoal.Length == 0)
                {
                    return 0;
                }

                //   if (shoal.Length == 1)
                // {
                //   return Convert.ToInt16(shoal);
                //}

                if (shoal.Contains("-"))
                {
                    shoal = shoal.Replace(",", "");
                    shoal = shoal.Replace("\n", "");
                    shoal = shoal.Replace("//", "");
                    shoal = shoal.Replace(";", "");
                    shoal = shoal.Replace("*", "");
                    shoal = shoal.Replace("%", "");
                    shoal = shoal.Replace("[", "");
                    shoal = shoal.Replace("]", "");

                    var numbersToArray1 = shoal.ToCharArray();
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < numbersToArray1.Length; i++)
                    {
                        if (numbersToArray1[i].Equals("-"))
                        {
                            stringBuilder.Append("-");
                            stringBuilder.Append(numbersToArray1[i++]);
                            stringBuilder.Append(",");

                        }


                    }

                    throw new Exception($"negatives {stringBuilder.ToString()} not allowed");

                }



                shoal = shoal.Replace(",", "");
                shoal = shoal.Replace("\n", "");
                shoal = shoal.Replace("//", "");
                shoal = shoal.Replace(";", "");
                shoal = shoal.Replace("*", "");
                shoal = shoal.Replace("%", "");
                shoal = shoal.Replace("[", "");
                shoal = shoal.Replace("]", "");

                var numbersToArray = shoal.ToCharArray();
                int sum = 0;

                foreach (var item in numbersToArray)
                {
                    sum += Convert.ToInt32(item.ToString());
                }


                return sum;
            }

        }


    }
