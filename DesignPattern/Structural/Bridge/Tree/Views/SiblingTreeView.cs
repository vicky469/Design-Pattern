using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Structural.Bridge.Tree.Views
{
    public class SiblingTreeView : ITreeView
    {
        public IEnumerable<TreeNode> GetNodes(TreeNode root, TreeViewOptions options)
        {
            // If root has no parent, it has no siblings
            if (root.Parent == null)
            {
                return new[] { root };
            }

            // Get all children of the parent (these are the siblings including the root node)
            return root.Parent.Children
                .Where(node => 
                    options.IncludedTypes.Contains(node.Type) &&
                    (string.IsNullOrEmpty(options.SearchTerm) || 
                     node.Name.Contains(options.SearchTerm, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
