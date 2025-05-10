using System.Collections.Generic;

namespace DesignPattern.Structural.Bridge.Tree
{
    public interface ITreeView
    {
        IEnumerable<TreeNode> GetNodes(TreeNode root, TreeViewOptions options);
    }
}
