Lista Ordenada com método de exclusão:

public class ListaOrdenada
{
    private Node head;

    public void InserirOrdenado(int data)
    {
        Node newNode = new Node(data);
        if (head == null || head.Data >= newNode.Data)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null && current.Next.Data < newNode.Data)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
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
}
