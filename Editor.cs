using System;
using System.Text;
namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start() 
        {
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("---------------");
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine("1 - Salvar");
            Console.WriteLine("2 - Sair");
            short res = short.Parse(Console.ReadLine());
            switch(res)
            {
                case 1: Salvar(file);break;
                case 2: Menu.Show();break;
            }
            Viewer.Show(file.ToString());   
            Menu.Show();      
        }

        static void Salvar( StringBuilder? file)
        {
            Console.Clear();
            Console.WriteLine("Qual o melhor caminho para salvar o arquivo? ");
            var path = Console.ReadLine();

            using(var folder = new StreamWriter(path))
            {
                folder.Write(file);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            
            
        }
    }
}