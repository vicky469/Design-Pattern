using System;
using DesignPattern.Core;
using DesignPattern.Structural.Bridge.Tree;
using DesignPattern.Structural.Bridge.Tree.Views;

namespace DesignPattern.Structural.Bridge
{
    public class BridgePatternRunner : DesignPatternRunner
    {
        public override DesignPatternType PatternType => DesignPatternType.Bridge;

        protected override void RunPattern()
        {
            // Create a sample enterprise tree
            var root = new EnterpriseNode("Enterprise Corp", NodeType.Department)
            {
                Id = 1,
                Code = "CORP"
            };

            var engineering = new EnterpriseNode("Engineering", NodeType.Department)
            {
                Id = 2,
                Code = "ENG",
                Parent = root
            };
            root.Children.Add(engineering);

            var backend = new EnterpriseNode("Backend Team", NodeType.Team)
            {
                Id = 3,
                Code = "BE",
                Parent = engineering
            };
            engineering.Children.Add(backend);

            var apiProject = new EnterpriseNode("API Project", NodeType.Project)
            {
                Id = 4,
                Code = "API",
                Parent = backend
            };
            backend.Children.Add(apiProject);

            // Demonstrate different tree views
            Console.WriteLine("Ancestor View from API Project:");
            DemonstrateTreeView(new AncestorTreeView(), apiProject);

            Console.WriteLine("\n-------------------\n");

            Console.WriteLine("Descendants View from Engineering:");
            DemonstrateTreeView(new DescendantsTreeView(), engineering);

            Console.WriteLine("\n-------------------\n");

            Console.WriteLine("Filtered View (Departments and Teams only):");
            var options = new TreeViewOptions
            {
                IncludedTypes = new HashSet<NodeType> { NodeType.Department, NodeType.Team },
                MaxDepth = 2
            };
            DemonstrateTreeView(new FilteredTreeView(), root, options);

            Console.WriteLine("\n-------------------\n");

            Console.WriteLine("Sibling View from Backend Team:");
            DemonstrateTreeView(new SiblingTreeView(), backend);

            Console.WriteLine("\n-------------------\n");

            // Demonstrate search functionality
            Console.WriteLine("Search Results for 'Team' across different views:");
            var searchOptions = new TreeViewOptions
            {
                IncludedTypes = new HashSet<NodeType> { NodeType.Department, NodeType.Team, NodeType.Project },
                SearchTerm = "Team"
            };

            Console.WriteLine("\nFiltered View Search:");
            DemonstrateTreeView(new FilteredTreeView(), root, searchOptions);

            Console.WriteLine("\nDescendants View Search from Engineering:");
            DemonstrateTreeView(new DescendantsTreeView(), engineering, searchOptions);

            Console.WriteLine("\nAncestor View Search from API Project:");
            DemonstrateTreeView(new AncestorTreeView(), apiProject, searchOptions);

            Console.WriteLine("\nSibling View Search from Backend Team:");
            DemonstrateTreeView(new SiblingTreeView(), backend, searchOptions);

            // Demonstrate case-insensitive search
            Console.WriteLine("\n-------------------\n");
            Console.WriteLine("Case-insensitive Search Results for 'api' across different views:");
            var caseInsensitiveOptions = new TreeViewOptions
            {
                IncludedTypes = new HashSet<NodeType> { NodeType.Department, NodeType.Team, NodeType.Project },
                SearchTerm = "api"
            };

            Console.WriteLine("\nFiltered View Search:");
            DemonstrateTreeView(new FilteredTreeView(), root, caseInsensitiveOptions);
        }

        private void DemonstrateTreeView(ITreeView view, TreeNode root, TreeViewOptions options = null)
        {
            options ??= TreeViewOptions.Default;
            var nodes = view.GetNodes(root, options);
            foreach (var node in nodes)
            {
                Console.WriteLine($"{new string('-', node.Level * 2)}{node}");
            }
        }
    }
}
