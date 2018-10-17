using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishsGameKata
{
    class Class1
    {
        public int Fish(string fishs)
        {


            int s = SumOfCharOfString(fishs);
            int newSizeOfFish = 0;
            newSizeOfFish = s / 4;
            return (s);


        }


        public int SumOfCharOfString(string fishs)
        {


            if (fishs.Length == 0)
            {
                return 0;
            }

            if (fishs.Contains("-"))
            {
                fishs = fishs.Replace(",", "");
                fishs = fishs.Replace("\n", "");
                fishs = fishs.Replace("//", "");
                fishs = fishs.Replace(";", "");
                fishs = fishs.Replace("*", "");
                fishs = fishs.Replace("%", "");
                fishs = fishs.Replace("[", "");
                fishs = fishs.Replace("]", "");

                var numbToArray = fishs.ToCharArray();
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < numbToArray.Length; i++)
                {
                    if (numbToArray[i].Equals("-"))
                    {
                        stringBuilder.Append("-");
                        stringBuilder.Append(numbToArray[i++]);
                        stringBuilder.Append(",");

                    }

                }

                throw new Exception($"negatives {stringBuilder.ToString()} not allowed");

            }
            fishs = fishs.Replace(",", "");
            fishs = fishs.Replace("\n", "");
            fishs = fishs.Replace("//", "");
            fishs = fishs.Replace(";", "");
            fishs = fishs.Replace("*", "");
            fishs = fishs.Replace("%", "");
            fishs = fishs.Replace("[", "");
            fishs = fishs.Replace("]", "");



            var numToArray = fishs.ToCharArray();
            int sum = 0;

            foreach (var item in numToArray)
            {
                sum += Convert.ToInt32(item.ToString());
            }


            return sum;
        }

    }
}
