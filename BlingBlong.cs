using System;
namespace WantToPlayAGame {
    public class Game {
        string value;
        public Game(string value){
            this.value = value;
        }
        
        public static void Games(){
        for (int i = 0; i <= 100; i++) {
            if (i % 3 == 0 && i % 5 == 0){
                Console.WriteLine("Bling Bong");
            }
            else if (i % 3 == 0){
                Console.WriteLine("Bling");
            }
            else if (i % 5 == 0){
                Console.WriteLine("Blong");
            }
            else{
                Console.WriteLine(i);
            }
        }
    }
    }
}