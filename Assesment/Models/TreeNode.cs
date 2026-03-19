namespace Assesment.Models
{
    public class TreeNode
    {
        public string Name { get; set; }
        public string? City { get; set; } // for filter
        public List<TreeNode> Children { get; set; } = new();
    }
}
