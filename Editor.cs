using System.Text;

namespace EditorHTML{
    public static class Editor {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\n =========== MODO DE EDIÇÃO ===========\n");
            Thread.Sleep(650);
            Console.WriteLine("Digite seu texto abaixo || Pressione [ESC] para sair ");
            // Start();
        }
    }
}
