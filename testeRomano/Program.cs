using System;
using System.Collections.Generic;

namespace testeRomano
{
    class Program
    {
        static void Main(string[] args)
        {

            int R = 0;

            Console.Write("Digite o número romano em MAIUSCULO: ");
            string n = Console.ReadLine();

            int Indices = n.Length;



            for (int z = 0; z < Indices; z++)
            {
                if (n.Length == z + 1)
                {
                    for (int i = 0; i < n.Length; i++)
                    {
                        char k = n[i];

                        if (k == 'I')
                        {
                            R = R + 1;
                        }

                        else if (k == 'V')
                        {
                            R = R + 5;
                        }

                        else if (k == 'X')
                        {
                            R = R + 10;
                        }
                    }
                }
            }

            int i1 = n.LastIndexOf("I");
            int i2 = n.LastIndexOf("V");
            int i3 = n.LastIndexOf("X");

            if (i1 != -1)
            {
                if (i1 < i2 || i1 < i3)
                {
                    R = R - 2;
                }
            }

            Console.WriteLine(R);
        }
    }
}
