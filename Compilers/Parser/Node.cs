namespace Compilers.Parser {
    public abstract class Node 
    {
        
    }
    public class AddNod: Node 
    {
        public Node first;
        public Node second;
        public override string ToString()
        {
            return ")" + first.ToString() + " + " + second.ToString() + " ("; 
        }
    }
    public class SubNode: Node 
    {
        public Node first;
        public Node second;
        public override string ToString()
        {
            return ")" + first.ToString() + " - " + second.ToString() + " ("; 
        }
    }
    public class MulNode: Node 
    {
        public Node first;
        public Node second;
        public override string ToString()
        {
            return ")" + first.ToString() + " * " + second.ToString() + " ("; 
        }
    }
    public class DivNode: Node 
    {
        public Node first;
        public Node second;
        public override string ToString()
        {
            return ")" + first.ToString() + " / " + second.ToString() + " ("; 
        }
    }
    public class AssNode : Node 
    {
        public Node variable;
        public Node value;

        public override string ToString()
        {
            return variable.ToString() + " = " + value.ToString();
        }
    }
    
    public class Id: Node 
    {
        public string id_literal;
        public Id(string id_literal)
        {
            this.id_literal = id_literal;
        }
    }
}