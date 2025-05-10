using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Prototype.ReportExample.Reports
{
    public class FinancialReportTemplate : IReportTemplate
    {
        public string ReportType => "Financial";
        public string Title { get; set; }
        public Dictionary<string, string> Parameters { get; private set; }
        public List<string> DataSources { get; private set; }
        public List<string> Charts { get; private set; }
        
        // Financial-specific properties
        public string FiscalPeriod { get; set; }
        public string AccountingStandard { get; set; }
        public List<string> CurrencyConversions { get; private set; }

        public FinancialReportTemplate()
        {
            Parameters = new Dictionary<string, string>();
            DataSources = new List<string>();
            Charts = new List<string>();
            CurrencyConversions = new List<string>();
        }

        public object Clone()
        {
            var clone = new FinancialReportTemplate
            {
                Title = this.Title,
                FiscalPeriod = this.FiscalPeriod,
                AccountingStandard = this.AccountingStandard,
                Parameters = new Dictionary<string, string>(this.Parameters),
                DataSources = new List<string>(this.DataSources),
                Charts = new List<string>(this.Charts),
                CurrencyConversions = new List<string>(this.CurrencyConversions)
            };
            return clone;
        }

        public void ConfigureLayout()
        {
            Console.WriteLine($"Configuring layout for {Title} financial report");
            Console.WriteLine($"Fiscal Period: {FiscalPeriod}");
            Console.WriteLine($"Accounting Standard: {AccountingStandard}");
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

        public void Display()
        {
            Console.WriteLine($"\nFinancial Report: {Title}");
            Console.WriteLine($"Fiscal Period: {FiscalPeriod}");
            Console.WriteLine($"Accounting Standard: {AccountingStandard}");
            Console.WriteLine("\nParameters:");
            foreach (var param in Parameters)
            {
                Console.WriteLine($"  {param.Key}: {param.Value}");
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
            Console.WriteLine("\nCurrency Conversions:");
            foreach (var currency in CurrencyConversions)
            {
                Console.WriteLine($"  {currency}");
            }
        }
    }
}
