using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Structural.Bridge.Tree.Views
{
    public class DescendantsTreeView : ITreeView
    {
        public IEnumerable<TreeNode> GetNodes(TreeNode root, TreeViewOptions options)
        {
            return root.TraverseDown()
                .Where(node => 
                    options.IncludedTypes.Contains(node.Type) &&
                    node.Level <= options.MaxDepth &&
                    (string.IsNullOrEmpty(options.SearchTerm) || 
                     node.Name.Contains(options.SearchTerm, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
