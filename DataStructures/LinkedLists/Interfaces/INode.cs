namespace DataStructures.LinkedLists.Interfaces;

public interface INode<T>
{
    T Value { get; }
    Node<T> Next { get; }
    bool IsEmpty();
}