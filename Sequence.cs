using System;
namespace SequenceOfNumbers{
    public class Numbers{
        public static void getNumbers(int number){
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i = 0; i < number + 1; i++){
                // 3
                int c = a + b;
                // 2
                a = b;
                // 3
                b = c; 

                // write line 0, 1, 1, 2, 3, 5
                Console.WriteLine(c);
            }
        }
    }
    
}