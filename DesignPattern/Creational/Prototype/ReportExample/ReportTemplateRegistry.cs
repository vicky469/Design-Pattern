using System;
using System.Collections.Generic;

namespace DesignPattern.Creational.Prototype.ReportExample
{
    public class ReportTemplateRegistry
    {
        private readonly Dictionary<string, IReportTemplate> _templates;

        public ReportTemplateRegistry()
        {
            _templates = new Dictionary<string, IReportTemplate>();
        }

        public void RegisterTemplate(string key, IReportTemplate template)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            if (template == null)
                throw new ArgumentNullException(nameof(template));

            _templates[key] = template;
            Console.WriteLine($"Registered template: {key} ({template.ReportType})");
        }

        public IReportTemplate GetTemplate(string key)
        {
            if (!_templates.ContainsKey(key))
                throw new KeyNotFoundException($"Template with key '{key}' not found.");

            Console.WriteLine($"Cloning template: {key}");
            return (IReportTemplate)_templates[key].Clone();
        }

        public void ListTemplates()
        {
            Console.WriteLine("\nAvailable Templates:");
            foreach (var template in _templates)
            {
                Console.WriteLine($"- {template.Key} ({template.Value.ReportType})");
            }
        }
    }
}
