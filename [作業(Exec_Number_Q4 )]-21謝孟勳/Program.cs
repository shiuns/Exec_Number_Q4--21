using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_Number_Q4____21謝孟勳
{
    //百元買百雞
    //想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元
    //字彙表:
    //公雞(Cock), 母雞(Hen), 小雞(Chicken)
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int cock = 0; cock <= 100 / 5; cock++)
            {
                for (int hen = 0; hen <= (100 - 5 * cock) / 3; hen++)
                { 
                    int chicken = 100 - cock - hen;

                    double price = 5 * cock + 3 * hen + (double)chicken / 3.0;
                    if (price == 100)
                    {
                        Console.WriteLine($"公雞{cock}隻, 母雞{hen}隻, 小雞{chicken}隻");
                    }

                }
            }
        }
    }
}
