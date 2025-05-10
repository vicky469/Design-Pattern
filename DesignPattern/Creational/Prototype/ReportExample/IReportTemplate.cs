using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Prototype.ReportExample
{
    public interface IReportTemplate : ICloneable
    {
        string ReportType { get; }
        string Title { get; set; }
        Dictionary<string, string> Parameters { get; }
        List<string> DataSources { get; }
        List<string> Charts { get; }
        void ConfigureLayout();
        void AddDataSource(string source);
        void AddChart(string chartType);
        void AddParameter(string key, string value);
        void Display();
    }
}
