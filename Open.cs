using System;

namespace EditorHtml
{
    public class Open
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAR ARQUIVO");
            Console.WriteLine("-----------");
            Console.ReadKey();
            View();
        }
        public static void View()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using(var folder = new StreamReader(path)) // Using: abrir e fechar arquivo  // new: inicializador de instancia (objeto alocado na memória) 
            {                                        // StreamReader/StreamWrite: ler/escrever arquivo
                string text = folder.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu.Show();
        }

        

       
    }
}