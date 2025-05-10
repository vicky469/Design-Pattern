using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Structural.Bridge.Tree.Views
{
    public class AncestorTreeView : ITreeView
    {
        public IEnumerable<TreeNode> GetNodes(TreeNode root, TreeViewOptions options)
        {
            return root.TraverseUp()
                .Where(node => 
                    node.Level > 0 &&
                    options.IncludedTypes.Contains(node.Type) &&
                    (string.IsNullOrEmpty(options.SearchTerm) || 
                     node.Name.Contains(options.SearchTerm, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
