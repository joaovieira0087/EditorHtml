using System;
using System.Text;

namespace EditorHtml
{
    class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("============");
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");;
            Console.WriteLine("============");
            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        
        public static void start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("============");
            Console.WriteLine(" Deseja salvar o arquivo? S/N");
            Viewer.Show(file.ToString());
            var option = Console.ReadKey();
            if (option.Key == ConsoleKey.S)
            {
                Console.WriteLine("Digite o caminho do arquivo para salvar:");
                var path = Console.ReadLine();
                System.IO.File.WriteAllText(path, file.ToString());
                Console.WriteLine($"Arquivo salvo em {path}");
            }
        }
    }
}