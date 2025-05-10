using DesignPattern.Structural.Bridge.Tree;
using DesignPattern.Structural.Bridge.Tree.Views;

namespace DesignPattern.Tests.Structural.Bridge.Tree
{
    [TestFixture]
    public class TreeViewTests
    {
        private TreeNode _root;
        private TreeNode _engineering;
        private TreeNode _backend;
        private TreeNode _frontend;
        private TreeNode _apiProject;
        private TreeNode _webProject;
        private TreeViewOptions _defaultOptions;

        [SetUp]
        public void Setup()
        {
            // Create a test tree structure
            _root = new EnterpriseNode("Enterprise Corp", NodeType.Department) { Id = 1 };
            
            _engineering = new EnterpriseNode("Engineering", NodeType.Department) { Id = 2, Parent = _root };
            _root.Children.Add(_engineering);
            
            _backend = new EnterpriseNode("Backend Team", NodeType.Team) { Id = 3, Parent = _engineering };
            _frontend = new EnterpriseNode("Frontend Team", NodeType.Team) { Id = 4, Parent = _engineering };
            _engineering.Children.Add(_backend);
            _engineering.Children.Add(_frontend);
            
            _apiProject = new EnterpriseNode("API Project", NodeType.Project) { Id = 5, Parent = _backend };
            _webProject = new EnterpriseNode("Web Project", NodeType.Project) { Id = 6, Parent = _frontend };
            _backend.Children.Add(_apiProject);
            _frontend.Children.Add(_webProject);

            _defaultOptions = new TreeViewOptions
            {
                IncludedTypes = new HashSet<NodeType> { NodeType.Department, NodeType.Team, NodeType.Project },
                MaxDepth = int.MaxValue
            };
        }

        [Test]
        public void DescendantsView_ReturnsAllDescendants()
        {
            // Arrange
            var view = new DescendantsTreeView();

            // Act
            var nodes = view.GetNodes(_engineering, _defaultOptions).ToList();

            // Assert
            Assert.That(nodes, Has.Count.EqualTo(5)); // Engineering + 2 teams + 2 projects
            Assert.That(nodes, Contains.Item(_engineering));
            Assert.That(nodes, Contains.Item(_backend));
            Assert.That(nodes, Contains.Item(_frontend));
            Assert.That(nodes, Contains.Item(_apiProject));
            Assert.That(nodes, Contains.Item(_webProject));
        }

        [Test]
        public void AncestorView_ReturnsAllAncestors()
        {
            // Arrange
            var view = new AncestorTreeView();

            // Act
            var nodes = view.GetNodes(_apiProject, _defaultOptions).ToList();

            // Assert
            Assert.That(nodes, Has.Count.EqualTo(3)); // API Project + Backend Team + Engineering
            Assert.That(nodes, Contains.Item(_apiProject));
            Assert.That(nodes, Contains.Item(_backend));
            Assert.That(nodes, Contains.Item(_engineering));
        }

        [Test]
        public void SiblingView_ReturnsSiblingsIncludingSelf()
        {
            // Arrange
            var view = new SiblingTreeView();

            // Act
            var nodes = view.GetNodes(_backend, _defaultOptions).ToList();

            // Assert
            Assert.That(nodes, Has.Count.EqualTo(2)); // Backend Team + Frontend Team
            Assert.That(nodes, Contains.Item(_backend));
            Assert.That(nodes, Contains.Item(_frontend));
        }

        [Test]
        public void FilteredView_WithTypeFilter_ReturnsOnlySpecifiedTypes()
        {
            // Arrange
            var view = new FilteredTreeView();
            var options = new TreeViewOptions
            {
                IncludedTypes = new HashSet<NodeType> { NodeType.Team },
                MaxDepth = int.MaxValue
            };

            // Act
            var nodes = view.GetNodes(_root, options).ToList();

            // Assert
            Assert.That(nodes, Has.Count.EqualTo(2)); // Only Backend and Frontend teams
            Assert.That(nodes.All(n => n.Type == NodeType.Team), Is.True);
            Assert.That(nodes, Contains.Item(_backend));
            Assert.That(nodes, Contains.Item(_frontend));
        }

        [Test]
        public void AllViews_WithSearchTerm_ReturnsCaseInsensitiveMatches()
        {
            // Arrange
            var views = new ITreeView[]
            {
                new FilteredTreeView(),
                new DescendantsTreeView(),
                new AncestorTreeView(),
                new SiblingTreeView()
            };
            var options = new TreeViewOptions
            {
                IncludedTypes = new HashSet<NodeType> { NodeType.Department, NodeType.Team, NodeType.Project },
                SearchTerm = "team"
            };

            foreach (var view in views)
            {
                // Act
                var nodes = view.GetNodes(_engineering, options).ToList();

                // Assert
                Assert.That(nodes.All(n => n.Name.Contains("Team", StringComparison.OrdinalIgnoreCase)), 
                    Is.True, $"Failed for {view.GetType().Name}");
            }
        }

        [Test]
        public void AllViews_WithDepthLimit_RespectsMaxDepth()
        {
            // Arrange
            var views = new ITreeView[]
            {
                new FilteredTreeView(),
                new DescendantsTreeView()
            };
            var options = new TreeViewOptions
            {
                IncludedTypes = new HashSet<NodeType> { NodeType.Department, NodeType.Team, NodeType.Project },
                MaxDepth = 1 // Only root and its immediate children
            };

            foreach (var view in views)
            {
                // Act
                var nodes = view.GetNodes(_root, options).ToList();

                // Assert
                Assert.That(nodes.All(n => n.Level <= 1), 
                    Is.True, $"Failed for {view.GetType().Name}");
            }
        }
    }
}
