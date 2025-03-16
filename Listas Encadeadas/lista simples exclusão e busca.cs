Lista Simples com métodos de exclusão e busca:

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
        if (head == null) return;

        if (head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        while (current.Next != null && current.Next.Data != data)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public Node Buscar(int data)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data == data)
            {
                return current;
            }
            current = current.Next;
        }
        return null; // Não encontrado
    }
}
