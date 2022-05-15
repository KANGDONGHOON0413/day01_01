using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //.net에서 사용하는 기본타입
            System.Int16 short001 = 16;
            System.Int32 int001 = 32;
            System.Int64 long001 = 64;
            System.Byte byte001 = 255;
            Console.WriteLine(short001 + long001);

            //c#/.net에서 사용되는 실수형 타입
            float f1 = 5.2f;
            System.Single f2 = 5.2f;
            double d1 = 6.01;
            System.Double d2 = 6.01;
            decimal money1 = 6.0099m;
            System.Decimal money2= 6.0099m;
            //float와 double은 정밀도 차이에 그치지만, decimal의 경우 반올림 오차를 허용하지 않아 회계에 적합하다
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine("돈: " + money1);
            Console.WriteLine(f2);
            Console.WriteLine(d2);
            Console.WriteLine("돈: " + money2);

            //문자형
            System.String s1 = "Hello C# .net";
            Console.WriteLine(s1);
            //불대수
            Boolean istrue = (d1 != 0);
            System.Boolean isright = (d1 == 0);
            Console.WriteLine(istrue + "\n" + isright);


            //LOOP를 이용한 반복문(처음 봤기에 적어봤다. 직관성이 떨어져서 사용하지 않는다.)
            /*
            int sum;
            int n=0;
            
            LOOP:
             n++;
            if(n>100) goto LOOPEXIT;
            if((n%2) != 0) goto LOOP;
             sum +=n;
            goto LOOP;

            LOOPEXIT: Console.Write(sum);
            */
        }
    }
}
