public class NodeArvore
{
    public int Data;
    public NodeArvore Left;
    public NodeArvore Right;

    public NodeArvore(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class ArvoreBinaria
{
    private NodeArvore root;

    public void Inserir(int data)
    {
        root = InserirRecursivo(root, data);
    }

    private NodeArvore InserirRecursivo(NodeArvore node, int data)
    {
        if (node == null)
        {
            return new NodeArvore(data);
        }

        if (data < node.Data)
        {
            node.Left = InserirRecursivo(node.Left, data);
        }
        else if (data > node.Data)
        {
            node.Right = InserirRecursivo(node.Right, data);
        }

        return node;
    }

    public void PercorrerEmOrdem(NodeArvore node)
    {
        if (node != null)
        {
            PercorrerEmOrdem(node.Left);
            Console.WriteLine(node.Data);
            PercorrerEmOrdem(node.Right);
        }
    }
}
