using System.Text.RegularExpressions;

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
            Replace(text);
            Console.WriteLine("\n|| Pressione qualquer tecla para retornar ao Menu ||");
            Console.ReadKey();
            Menu.Show();
        }
        public static void Replace(string text){ 
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            } 
        }

        public static void AcessFile(){
            Console.WriteLine("Insira o caminho do arquivo || Ex: C:\\Projetos\\");
            string path = Console.ReadLine();
            Console.WriteLine("Insira o nome do arquivo || Inclua a extensão (.txt)");
            string nameFile = Console.ReadLine();

            string concatena = path+nameFile;

            Console.WriteLine(concatena);
            
            using(var file = new StreamReader(concatena)){
                string text = file.ReadToEnd();
                Console.WriteLine("\nConteúdo do arquivo:");
                Console.WriteLine(" ");
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu");
            Console.ReadKey();
            Menu.Show();
        }
    }
}