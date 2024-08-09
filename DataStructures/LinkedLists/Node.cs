using DataStructures.LinkedLists.Interfaces;

namespace DataStructures.LinkedLists;

public class Node<T>(T value, Node<T> next = default) : INode<T>
{
    public T Value { get; } = value;
    public Node<T> Next { get; private set; } = next;
    
    public bool IsEmpty()
    {
        return Value == null;
    }

    public void SetNext(Node<T> next)
    {
        Next = next;
    }

    public static Node<T> Create(T value)
    {
        return new Node<T>(value);
    }
    
    public static Node<T> Create(T value, Node<T> next)
    {
        return new Node<T>(value, next);
    }
}