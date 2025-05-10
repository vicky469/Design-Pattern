using DesignPattern.Behavioral.Visitor.Elements;
using DesignPattern.Behavioral.Visitor.Interfaces;

namespace DesignPattern.Behavioral.Visitor.Visitors
{
    /// <summary>
    /// Concrete Visitor that counts words and images
    /// </summary>
    public class StatisticsVisitor : IDocumentVisitor
    {
        public int WordCount { get; private set; }
        public int ImageCount { get; private set; }
        public int TableCount { get; private set; }
        public int TableCellCount { get; private set; }

        public void Visit(Paragraph paragraph)
        {
            WordCount += paragraph.Text.Split(' ').Length;
        }

        public void Visit(Image image)
        {
            ImageCount++;
        }

        public void Visit(Table table)
        {
            TableCount++;
            TableCellCount += table.Headers.Count; // Count header cells
            foreach (var row in table.Data)
            {
                TableCellCount += row.Count; // Count data cells
                foreach (var cell in row)
                {
                    WordCount += cell.Split(' ').Length; // Count words in cells
                }
            }
        }

        public override string ToString()
        {
            return $"Statistics: {WordCount} words, {ImageCount} images, {TableCount} tables ({TableCellCount} cells)";
        }
    }
}
