using System;
using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace WebScraper {
    class Program {
        static void Main(string[] args) {
            HtmlWeb web = new HtmlWeb();

            HtmlDocument doc = web.Load("https://en.wikipedia.org/wiki/Greece");

            var HeaderNames = doc.DocumentNode.SelectNodes("//span[@class='toctext']");

            var titles = new List<Row>();

            foreach (var item in HeaderNames) {
                titles.Add(new Row {Title = item.InnerText});
            }

            foreach (var item in titles)
            {
                Console.WriteLine(item.Title);
            }

            using (var writer = new StreamWriter("./data.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
            csv.WriteRecords(titles);
            }
        }
    }
}
