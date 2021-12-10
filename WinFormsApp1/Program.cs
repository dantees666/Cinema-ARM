using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace CinemaARM
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InterForm());

            //Film film = new Film("»Î‚˚‡˚‚");
            //Serial film1 = new Serial("‡‡‡‡‡˚‚");
            //List<Show> Shows = new List<Show>();

            //string writePath = "TestWrite.json";

            //StreamWriter file = File.CreateText(writePath);
            //file.WriteLine(film.serializeShow());
            //file.WriteLine(film1.serializeShow());
            //file.Close();


            //StreamReader sw = File.OpenText(writePath);
            //string line;

            //while ((line = sw.ReadLine()) != null)
            //{
            //    if (line.Contains("Count_of_series"))
            //        Shows.Add(JsonSerializer.Deserialize<Serial>(line));
            //    else
            //        Shows.Add(JsonSerializer.Deserialize<Film>(line));
            //}

            //Console.WriteLine("");
        }
    }
}
