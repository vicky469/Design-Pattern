using System.Collections.Generic;

namespace DesignPattern.Structural.Bridge.Tree
{
    public class TreeViewOptions
    {
        public HashSet<NodeType> IncludedTypes { get; set; } = new();
        public int MaxDepth { get; set; } = int.MaxValue;
        public bool IncludeHidden { get; set; }
        public bool IncludeInactive { get; set; }
        public string SearchTerm { get; set; }
        
        public static TreeViewOptions Default => new()
        {
            IncludedTypes = new HashSet<NodeType> { NodeType.Department, NodeType.Team, NodeType.Project },
            MaxDepth = int.MaxValue,
            IncludeHidden = false,
            IncludeInactive = false
        };
    }
}
