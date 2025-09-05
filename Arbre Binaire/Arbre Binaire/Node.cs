public class Node
{
    private string word;
    private Node left;
    private Node right;
    
    public Node(string w, Node n1=null, Node n2=null)
    {
        word=w;
        left=n1;
        right=n2;
    }
}




public class Vehicule
{
    private string marque;
    private int annee;

    public Vehicule(string m, int a)
    {
        marque=m;
        annee=a;
    }
}