namespace EditorHTML{
    public static class Menu{

        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green; //cor de fundo
            Console.ForegroundColor = ConsoleColor.Black; //cor da letra

            Console.Clear();
            DrawScreen();
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 38; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }
    }
}