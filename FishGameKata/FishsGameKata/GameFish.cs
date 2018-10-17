using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishsGameKata
{
    public class GameFish
    {
        public int Fish(string fishs)
        {
            if (fishs.Length == 0)
            {
                return 1;
            } 
                int[] mytab = RemplirTab(fishs);
            
                int level = 1;
                bool x = Tabnull(mytab);
   
                while (x == false)
                {
                    switch (level)
                    {

                        case 1:
                            if (mytab[1] >= 4)
                            {
                                level++;
                                mytab[1] = mytab[1] - 4;
                            }

                            break;

                        case 2:
                            if (mytab[1] >= 8)
                            {
                                level++;
                                mytab[1] = mytab[1] - 8;
                            }
                            if (mytab[2] >= 4)
                            {
                                level++;
                                mytab[2] = mytab[2] - 4;
                            }

                            break;
                        case 3:
                            if (mytab[1] >= 12)
                            {
                                level++;
                                mytab[1] = mytab[1] - 12;
                            }
                            if (mytab[2] >= 6)
                            {
                                level++;
                                mytab[2] = mytab[2] - 6;
                            }
                            if (mytab[3] >= 4)
                            {
                                level++;
                                mytab[3] = mytab[3] - 4;
                            }
                            break;
                        case 4:
                            if (mytab[1] >= 16)
                            {
                                level++;
                                mytab[1] = mytab[1] - 16;
                            }
                            if (mytab[2] >= 8)
                            {
                                level++;
                                mytab[2] = mytab[2] - 8;
                            }
                            if (mytab[4] >= 4)
                            {
                                level++;
                                mytab[4] = mytab[4] - 4;
                            }
                            break;
                        case 5:
                            if (mytab[1] >= 20)
                            {
                                level++;
                                mytab[1] = mytab[1] - 20;
                            }
                            if (mytab[2] >= 10)
                            {
                                level++;
                                mytab[2] = mytab[2] - 10;
                            }
                            if (mytab[4] >= 5)
                            {
                                level++;
                                mytab[4] = mytab[4] - 5;
                            }
                            if (mytab[5] >= 4)
                            {
                                level++;
                                mytab[5] = mytab[5] - 4;
                            }
                            break;
                        case 6:
                            if (mytab[1] >= 24)
                            {
                                level++;
                                mytab[1] = mytab[1] - 24;
                            }
                            if (mytab[2] >= 12)
                            {
                                level++;
                                mytab[2] = mytab[2] - 12;
                            }
                            if (mytab[3] >= 8)
                            {
                                level++;
                                mytab[3] = mytab[3] - 8;
                            }
                            if (mytab[4] >= 6)
                            {
                                level++;
                                mytab[4] = mytab[4] - 6;
                            }
                            if (mytab[6] >= 4)
                            {
                                level++;
                                mytab[6] = mytab[6] - 4;
                            }
                            break;
                    }
                }

                return level;
            
        }

        //Verifier si le tableau soit vide
        public bool Tabnull(int[] tabl)
        {
            bool nul = true;
            int i = 0;

            while (i < 10 && nul == true)
            {
                if (tabl[i] == 0)
                {
                    nul = true;
                    i++;
                }
                else
                    nul = false;

            }
            return nul;
        }
    //Remplir un tableau qui contient pour chaque element le nombre d'occurrences {tabl[i]} de char {i}
        public int[] RemplirTab(string word)
        {
            int[] mytabl = new int[10]; ;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (word.Contains(i.ToString()))
                        mytabl[i] = mytabl[i] + 1;

                }
            }
            return mytabl;

        }
        


    }
}
