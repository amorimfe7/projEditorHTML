using System.Linq.Expressions;

namespace EditorHTML{
    public static class Menu{

        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue; //cor de fundo
            Console.ForegroundColor = ConsoleColor.Black; //cor da letra

            DrawScreen();
        }

        public static void DrawScreen()
        {                    
            BorderTopBottom();
            BorderSides();    
            BorderTopBottom();
        }

        public static void BorderTopBottom(){
            
            Console.Write("+");
            for (int i = 0; i <= 49; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void BorderSides(){
            
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 49; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}