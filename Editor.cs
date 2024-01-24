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
            Start();
        }

        public static void Start() {
            var file = new StringBuilder();
             
            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine); 

            } while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\nADeseja salvar o arquivo?");
            Console.WriteLine("[1] - Sim || [2] - Não");

            short optionSave = short.Parse(Console.ReadLine());
        
            switch(optionSave){
                case 1: Save(file); break;
                case 2:{
                        Console.WriteLine("\n Fechando Editor...");
                        Thread.Sleep(900);
                        Menu.Show(); 
                        break;
                    }
                default: Menu.Show(); break;
            }
        }

        public static void Save(StringBuilder file){
                Console.WriteLine("\nInsira o caminho do arquivo || Ex: C:\\Projetos\\");
                string path = Console.ReadLine();
                Console.WriteLine("\nInsira o nome do arquivo || Inclua a extensão (.txt)");
                string nameFile = Console.ReadLine();
                string concatena = path+nameFile;

                using(var arq = new StreamWriter(concatena)){
                    arq.Write(file);
                }
                
                Console.WriteLine("\nProcessando arquivo..");
                Thread.Sleep(900);
                
                Console.WriteLine($"\n* Arquivo {nameFile} salvo com sucesso! *");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("\nDeseja visualizar o arquivo salvo?");
                Console.WriteLine("[1] - Sim || [2] - Não");
                short viewFile = short.Parse(Console.ReadLine());

                if (viewFile == 1){
                    Viewer.Show(file.ToString());
                    Console.ReadKey();
                    Menu.Show();
                } else{
                    Menu.Show();
                }
        }
    }
}
