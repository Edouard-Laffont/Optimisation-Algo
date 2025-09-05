
public class BinaryTree
{
    private Node root;

    public BinaryTree(string s)
    {
        Node r = new Node(s);
        root = r;
    }

    public void Add(string mot)
    {
        if (root == null)
        {
            root = new Node(mot);
        }
    }
    
    private void Display(){}

    public bool Search(string value)
    {
        Node current = root;
        while (current != null){}
    }
}