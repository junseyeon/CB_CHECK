using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            // 실수 : real number 정수 : inteager  float : 
            var number = 100;
            //number = "100";       이미 인트형으로 정의되어 있어 불가 

            var lotto = 10000000000L;           //100억  L로 long형 처리 
            var str = "안녕하세요";
            var this_double = 3.141592;
            var this_float = 3.14F;
            var this_bool = true;
            var this_char = 'H';

            Console.WriteLine("number: " + number.GetType());
            Console.WriteLine("lotto: " + lotto.GetType());
            Console.WriteLine("str: " + str.GetType());
            Console.WriteLine("this_double: " + this_double.GetType());
            Console.WriteLine("this_float: " + this_float.GetType());
            Console.WriteLine("this_bool: " + this_bool.GetType());
            Console.WriteLine("this_char: " + this_char.GetType());

            Console.WriteLine("int형 최대" + int.MaxValue);
            Console.WriteLine("int형 최소" + int.MinValue);                // 끝에 -~~~~8로 끝남    정수형은 어쩔수 ㅅ없음 long도 똑같이 
            Console.WriteLine("long형 최대" + long.MaxValue);
            Console.WriteLine("long형 최소" + long.MinValue);
            Console.WriteLine("float형 최대" + float.MaxValue);                //float이 long보다 압도적ㅇ로 많음 그래서 ~~~ 대입가능 
            Console.WriteLine("float형 최소" + float.MinValue);            //float는 똑같이 나옴  E = 10  10에 38승
            Console.WriteLine("double형 최대" + double.MaxValue);
            Console.WriteLine("double형 최소" + double.MinValue);
            Console.WriteLine("char형 최대" + char.MaxValue);
            Console.WriteLine("char형 최소" + char.MinValue);          //그냥 이상한 문자 나옴 

            // Literal 리터럴  : 코드에 박혀있는 ? 
            int i_int = 100;
            long i_lng = 100L;
            double i_dbl = 100.0;
            float i_flt = 100.0F;
            char i_chr = 'A';

            // 자료형의 표현 크기 (암묵적 형변환 가능) Type Casting ******          // long과 float 표현 가능한 수는 몇 바이트 크기와 반대 (가능한 수로 판별)
            i_dbl = i_flt = i_lng = i_int = i_chr;                                  // float 4바이트 long은ㅇ 8바이트지만 표현범위는 float가 훨씬 ㅡ큼 !



            string strInt = "50";
            string strLong = "20000000000"; // 200억
            string strDouble = "50.0";
            string strFloat = "50.278";
            string strString = "ABCDE";


            try
            {
                Console.WriteLine(int.Parse(strInt));           //String을 int로 
                Console.WriteLine(long.Parse(strLong));                 //string을 long으로 
                Console.WriteLine(double.Parse(strDouble));             //string을 double로 
                Console.WriteLine(float.Parse(strFloat));
                Console.WriteLine(int.Parse(strString));         //sgring을 double로 바꾸지 못함... 형식 에러남 
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("형식 에러 발생!");
                Console.WriteLine(e.Message);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }


            bool trueOrFalse = true;
            trueOrFalse.ToString();             //첫글자가 대문자라는 것을 조심하자  넣을 때는 소문자! ...

            int a = 1999;
            Console.WriteLine("" + a);          // int를 string으로 바꿔주는 부분 

            char c = 'a';
            string c2 = "" + 'a';
            Console.WriteLine(c2);              //char를 string으로 바꿔줌 
/*
            int aa = int.MinValue;
            Console.WriteLine(aa);
            // Console.WriteLine((long)-1 * aa);
            Console.WriteLine(-1 * aa);


            Console.WriteLine(-2147483648);
            Console.WriteLine((long)-1 * -2147483648);

            float bb = int.MinValue;
            Console.WriteLine(bb);
            Console.WriteLine(- 1 * bb);
            */

             int minInt = int.MaxValue;
            Console.WriteLine( minInt );    
            Console.WriteLine(-minInt);
            minInt = int.MinValue;
            Console.WriteLine("===============");
            Console.WriteLine(minInt);
            Console.WriteLine( - minInt );  // 주의: 양수에는 2147483648이 없어서 값이 변하지 않음
            Console.WriteLine(minInt * -1);  // 주의: 양수에는 2147483648이 없어서 값이 변하지 않음
            Console.WriteLine(minInt * -1L);  // long형으로 바꿔주면 해결(리터럴을 long형으로)
            Console.WriteLine((long)minInt * -1);  // long형으로 바꿔주면 해결(변수를 long으로)
            Console.WriteLine(-2147483648);  
            //Console.WriteLine(-(-2147483648)); // 직접 값을 명시하면 에러 발생,컴파일 안됨
            //Console.WriteLine(-1 * (-2147483648)); // 위와 동일
            Console.WriteLine(-1L * (-2147483648)); // long형으로 바꿔주면 해결(리터럴을 long형으로)
            Console.WriteLine((long) -1 * (-2147483648)); // long형으로 바꿔주면 해결(변수를 long으로)

            long minLong = long.MinValue;
            Console.WriteLine(minLong); // -9223372036854775808
            Console.WriteLine(-1 * minLong); // -1을 곱해도 값이 같다. long은 9223372036854775808 값을 표현할 수 없기 때문.
            Console.WriteLine(-1F * minLong); // float으로 한 경우. 9.223372E+18 로 소숫점 특정 자리수 이하 값이 왜곡되었다.
            Console.WriteLine(-1.0 * minLong); // double로 변경한 경우. 9.22337203685478E+18 로 좀 더 정밀해지긴 했지만 실제 값과는 다소 차이가 있다.

            Console.WriteLine(bool.Parse("true"));
        }
    }
}
