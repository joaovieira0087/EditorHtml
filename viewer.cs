using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("============");
            Replace(text);
            Console.WriteLine("============");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<s*trong>[^>]*>(.*?)<\s\s*/\s*trong>");
            Console.WriteLine(strong.Replace(text, m => m.Groups[1].Value.ToUpper()));

            var em = new Regex(@"<e*m*>[^>]*>(.*?)<\s\s*/\s*em>");
            Console.WriteLine(em.Replace(text, m => m.Groups[1].Value.ToLower()));
            Console.WriteLine(em.Replace(text, m => m.Groups[1].Value.ToLower()));


        }
    }
}