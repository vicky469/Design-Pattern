using System;
using DesignPattern.Core;
using DesignPattern.Creational.Prototype.DocumentExample;
using DesignPattern.Creational.Prototype.ReportExample;
using DesignPattern.Creational.Prototype.ReportExample.Reports;

namespace DesignPattern.Creational.Prototype
{
    public class PrototypePatternRunner : DesignPatternRunner
    {
        public override DesignPatternType PatternType => DesignPatternType.Prototype;

        protected override void RunPattern()
        {
            RunDocumentExample();
            Console.WriteLine("\n" + new string('=', 50) + "\n");
            RunReportExample();
        }

        private void RunDocumentExample()
        {
            Console.WriteLine("=== Document Template System Demo ===\n");

            // Create original templates
            var reportTemplate = new ReportTemplate(
                "Monthly Sales Report",
                "This report summarizes the monthly sales performance...",
                "John Doe"
            );
            reportTemplate.Metadata.Add("Department", "Sales");
            reportTemplate.Metadata.Add("Period", "Monthly");

            var emailTemplate = new EmailTemplate(
                "Customer Welcome Email",
                "Welcome to our service! We're excited to have you...",
                "Marketing Team",
                "Welcome to Our Service!"
            );
            emailTemplate.Recipients.Add("{{customer.email}}");
            emailTemplate.Metadata.Add("Category", "Welcome");
            emailTemplate.Metadata.Add("Priority", "High");

            // Display original templates
            Console.WriteLine("=== Original Templates ===");
            reportTemplate.Display();
            emailTemplate.Display();

            // Clone and customize templates
            Console.WriteLine("\n=== Cloned and Customized Templates ===");

            var quarterlyReport = (ReportTemplate)reportTemplate.Clone();
            quarterlyReport.Title = "Quarterly Sales Report";
            quarterlyReport.Metadata["Period"] = "Quarterly";
            quarterlyReport.Display();

            var reminderEmail = (EmailTemplate)emailTemplate.Clone();
            reminderEmail.Title = "Payment Reminder";
            reminderEmail.Subject = "Payment Due Reminder";
            reminderEmail.Content = "This is a friendly reminder about your upcoming payment...";
            reminderEmail.Metadata["Category"] = "Payment";
            reminderEmail.Display();
        }

        private void RunReportExample()
        {
            Console.WriteLine("=== Report Template System Demo ===\n");

            // Create template registry
            var registry = new ReportTemplateRegistry();

            // Create and register a financial report template
            var financialTemplate = new FinancialReportTemplate
            {
                Title = "Quarterly Financial Report",
                FiscalPeriod = "Q2 2025",
                AccountingStandard = "IFRS"
            };
            financialTemplate.AddParameter("Department", "Finance");
            financialTemplate.AddDataSource("SQL_Financial_DB");
            financialTemplate.AddChart("BalanceSheet");
            registry.RegisterTemplate("quarterly_financial", financialTemplate);

            // Create and register a sales report template
            var salesTemplate = new SalesReportTemplate
            {
                Title = "Monthly Sales Report",
                Period = "May 2025"
            };
            salesTemplate.AddProductCategory("Electronics");
            salesTemplate.AddProductCategory("Accessories");
            salesTemplate.AddRegion("North America");
            salesTemplate.AddChart("SalesTrend");
            salesTemplate.AddChart("RegionalComparison");
            registry.RegisterTemplate("monthly_sales", salesTemplate);

            // List available templates
            registry.ListTemplates();

            Console.WriteLine("\n=== Cloning and Customizing Templates ===\n");

            // Clone and customize financial report
            var customFinancial = (FinancialReportTemplate)registry.GetTemplate("quarterly_financial");
            customFinancial.Title = "Annual Financial Report 2025";
            customFinancial.FiscalPeriod = "FY 2025";
            customFinancial.AddChart("CashFlow");
            customFinancial.AddParameter("Auditor", "KPMG");
            customFinancial.Display();

            // Clone and customize sales report
            var customSales = (SalesReportTemplate)registry.GetTemplate("monthly_sales");
            customSales.Title = "Q2 Regional Sales Report";
            customSales.Period = "Q2 2025";
            customSales.AddRegion("Europe");
            customSales.AddProductCategory("Services");
            customSales.AddParameter("Currency", "USD");
            customSales.Display();
        }
    }
}
