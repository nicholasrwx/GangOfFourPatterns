using System.Text;

public class GraphicObject
    {
        public virtual string Name { get; set; } = "Group";
        public string Color;
        private Lazy<List<GraphicObject>> children = new Lazy<List<GraphicObject>>();
        public List<GraphicObject> Children => children.Value;

    // Compose a string to be printed
    private void Print(StringBuilder sb, int depth) {
        sb.Append(new string('*', depth))
        .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color} ")
        .AppendLine(Name);
        
        // Recursively iterate over children and further append their custom string values to the string builder
        foreach(var child in Children)
        {
            child.Print(sb, depth+1);
        }
    }

    // Calling writeline will access this override
    public override string ToString()
    {
        var sb = new StringBuilder();
        Print(sb, 0);
        return sb.ToString();
    }
}