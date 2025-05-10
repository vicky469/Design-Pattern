using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Structural.Bridge.Tree
{
    public abstract class TreeNode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NodeType Type { get; set; }
        public TreeNode Parent { get; set; }
        public List<TreeNode> Children { get; set; } = new();
        public int Level => Parent == null ? 0 : Parent.Level + 1;

        // Helper methods for traversal
        public IEnumerable<TreeNode> TraverseUp()
        {
            var current = this;
            while (current != null)
            {
                yield return current;
                current = current.Parent;
            }
        }

        public IEnumerable<TreeNode> TraverseDown()
        {
            yield return this;
            foreach (var child in Children)
            {
                foreach (var descendant in child.TraverseDown())
                {
                    yield return descendant;
                }
            }
        }

        public IEnumerable<TreeNode> Traverse()
        {
            return TraverseDown();
        }
    }

    public enum NodeType
    {
        Department,
        Team,
        Project,
        Role,
        Employee
    }
}
