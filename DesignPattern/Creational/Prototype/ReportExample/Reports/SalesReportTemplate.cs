using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Prototype.ReportExample.Reports
{
    public class SalesReportTemplate : IReportTemplate
    {
        public string ReportType => "Sales";
        public string Title { get; set; }
        public Dictionary<string, string> Parameters { get; private set; }
        public List<string> DataSources { get; private set; }
        public List<string> Charts { get; private set; }
        
        // Sales-specific properties
        public string Period { get; set; }
        public List<string> ProductCategories { get; private set; }
        public List<string> Regions { get; private set; }

        public SalesReportTemplate()
        {
            Parameters = new Dictionary<string, string>();
            DataSources = new List<string>();
            Charts = new List<string>();
            ProductCategories = new List<string>();
            Regions = new List<string>();
        }

        public object Clone()
        {
            var clone = new SalesReportTemplate
            {
                Title = this.Title,
                Period = this.Period,
                Parameters = new Dictionary<string, string>(this.Parameters),
                DataSources = new List<string>(this.DataSources),
                Charts = new List<string>(this.Charts),
                ProductCategories = new List<string>(this.ProductCategories),
                Regions = new List<string>(this.Regions)
            };
            return clone;
        }

        public void ConfigureLayout()
        {
            Console.WriteLine($"Configuring layout for {Title} sales report");
            Console.WriteLine($"Period: {Period}");
            Console.WriteLine("Categories: " + string.Join(", ", ProductCategories));
        }

        public void AddDataSource(string source)
        {
            DataSources.Add(source);
            Console.WriteLine($"Added data source: {source}");
        }

        public void AddChart(string chartType)
        {
            Charts.Add(chartType);
            Console.WriteLine($"Added chart: {chartType}");
        }

        public void AddParameter(string key, string value)
        {
            Parameters[key] = value;
            Console.WriteLine($"Added parameter: {key} = {value}");
        }

        public void AddProductCategory(string category)
        {
            ProductCategories.Add(category);
            Console.WriteLine($"Added product category: {category}");
        }

        public void AddRegion(string region)
        {
            Regions.Add(region);
            Console.WriteLine($"Added region: {region}");
        }

        public void Display()
        {
            Console.WriteLine($"\nSales Report: {Title}");
            Console.WriteLine($"Period: {Period}");
            
            Console.WriteLine("\nParameters:");
            foreach (var param in Parameters)
            {
                Console.WriteLine($"  {param.Key}: {param.Value}");
            }

            Console.WriteLine("\nProduct Categories:");
            foreach (var category in ProductCategories)
            {
                Console.WriteLine($"  {category}");
            }

            Console.WriteLine("\nRegions:");
            foreach (var region in Regions)
            {
                Console.WriteLine($"  {region}");
            }

            Console.WriteLine("\nData Sources:");
            foreach (var source in DataSources)
            {
                Console.WriteLine($"  {source}");
            }

            Console.WriteLine("\nCharts:");
            foreach (var chart in Charts)
            {
                Console.WriteLine($"  {chart}");
            }
        }
    }
}
