namespace DesignPattern.Structural.Bridge.Tree
{
    public class EnterpriseNode : TreeNode
    {
        public string Code { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsHidden { get; set; }
        public string Description { get; set; }
        public Dictionary<string, string> Metadata { get; set; } = new();

        public EnterpriseNode(string name, NodeType type)
        {
            Name = name;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Type}: {Name} (Code: {Code}, Level: {Level})";
        }
    }
}
