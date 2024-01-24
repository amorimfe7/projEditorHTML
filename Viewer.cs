namespace EditorHTML{
    public class Viewer(){
        public static void Show(string text){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\n =========== MODO DE VISUALIZAÇÃO ===========\n");
            Thread.Sleep(500);
            Console.WriteLine("Abrindo arquivo..");
            Thread.Sleep(800);
            // Replace(text);
            Console.WriteLine("\n|| Pressione qualquer tecla para retornar ao Menu ||");
            Console.ReadKey();
            Menu.Show();
        }
    }
}