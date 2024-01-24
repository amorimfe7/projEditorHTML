using System.Linq.Expressions;

namespace EditorHTML{
    public static class Menu{

        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue; //cor de fundo
            Console.ForegroundColor = ConsoleColor.Black; //cor da letra

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
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

        public static void WriteOptions(){
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("===========BEM VINDO AO EDITOR HTML===========");

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");

            Console.SetCursorPosition(3, 5);
            Console.WriteLine("[1] - Criar um novo arquivo");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("[2] - Visualizar um arquivo existente");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("[0] - Sair");

            Console.SetCursorPosition(3, 1);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option){
            
            switch(option){
                // case 1: Console.Clear(); Editor.Show(); break;
                // case 2: Console.Clear(); Viewer.AcessFile(); break;
                // case 3: Viewer.Show(""); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0); 
                    break;
                }
                default: Show(); break;
            }
        }
    }
}