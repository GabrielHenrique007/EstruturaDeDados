public class ListaSimples
{
    private Node head;

    public void Inserir(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Excluir(int data)
    {
        // Lógica para exclusão
    }

    public Node Buscar(int data)
    {
        // Lógica para busca
        return null;
    }
}
