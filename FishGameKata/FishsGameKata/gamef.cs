using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishsGameKata
{
    public class gamef
    {
        public int fish(string fishs)
        {
            int[] mytab = RemplirTab(fishs);
            int init = 1;
            bool x = Tabnull(mytab);
            while (x == false)
            {
                switch (init)
                {

                    case 1:
                        if (mytab[1] >= 4)
                        {
                            init++;
                            mytab[1] = mytab[1] - 4;
                        }

                        break;

                    case 2:
                        if (mytab[1] >= 8)
                        {
                            init++;
                            mytab[1] = mytab[1] - 8;
                        }
                        if (mytab[2] >= 4)
                        {
                            init++;
                            mytab[2] = mytab[2] - 4;
                        }

                        break;
                    case 3:
                        if (mytab[1] >= 12)
                        {
                            init++;
                            mytab[1] = mytab[1] - 12;
                        }
                        if (mytab[2] >= 6)
                        {
                            init++;
                            mytab[2] = mytab[2] - 6;
                        }
                        if (mytab[3] >= 4)
                        {
                            init++;
                            mytab[3] = mytab[3] - 4;
                        }
                        break;
                    case 4:
                        if (mytab[1] >= 16)
                        {
                            init++;
                            mytab[1] = mytab[1] - 16;
                        }
                        if (mytab[2] >= 8)
                        {
                            init++;
                            mytab[2] = mytab[2] - 8;
                        }
                        if (mytab[4] >= 4)
                        {
                            init++;
                            mytab[4] = mytab[4] - 4;
                        }
                        break;
                    case 5:
                        if (mytab[1] >= 20)
                        {
                            init++;
                            mytab[1] = mytab[1] - 20;
                        }
                        if (mytab[2] >= 10)
                        {
                            init++;
                            mytab[2] = mytab[2] - 10;
                        }
                        if (mytab[4] >= 5)
                        {
                            init++;
                            mytab[4] = mytab[4] - 5;
                        }
                        if (mytab[5] >= 4)
                        {
                            init++;
                            mytab[5] = mytab[5] - 4;
                        }
                        break;
                    case 6:
                        if (mytab[1] >= 24)
                        {
                            init++;
                            mytab[1] = mytab[1] - 24;
                        }
                        if (mytab[2] >= 12)
                        {
                            init++;
                            mytab[2] = mytab[2] - 12;
                        }
                        if (mytab[3] >= 8)
                        {
                            init++;
                            mytab[3] = mytab[3] - 8;
                        }
                        if (mytab[4] >= 6)
                        {
                            init++;
                            mytab[4] = mytab[4] - 6;
                        }
                        if (mytab[6] >= 4)
                        {
                            init++;
                            mytab[6] = mytab[6] - 4;
                        }
                        break;
                }
            }
            return init;
        }
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
