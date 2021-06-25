using IronPdf;
using System;
using System.Threading.Tasks;

namespace IronPDF_ExtractAllText_Exception
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var renderer = new HtmlToPdf();
            var pdf = await renderer.RenderHtmlAsPdfAsync("<h1>Hello World</h1>");

            var textAllPages = pdf.ExtractAllText(); //This line does not work, neither in asp.net core or console.

            foreach (var text in textAllPages)
            {
                Console.WriteLine(text);
            }

            Console.ReadKey();
        }
    }
}
