using System;
using System.Linq;

namespace Asg2_q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] l2 = new int[] { 1, 2, 3 };

            for (int i = 0; i < (l2.Length - 1); i++)
            {
                Array.Sort(l2);

                

            }
            
                bool stopProgram = false;
            int a =0;
            //While loop functions only based on True/False values for stopProgram
            while (stopProgram == false)
            {
                
                for (int j = 0; j < l2.Length; j++)
                {
                    
                    if (j + 1 < l2.Length)
                    {
                        if ((l2[j] < l2[j + 1]) && (l2[j + 1] != l2[j] + 1))
                        {

                            a = j;
                            Console.WriteLine(l2[j] + 1);
                           
                        }
                        
                    }
                    stopProgram = true;

                }
            }
            if (a == 0)
           Console.Write((l2[(l2.Length)-1]) +1);

        }
    }
}
