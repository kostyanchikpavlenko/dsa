using System.Collections;
using DataStructures.LinkedLists.Exceptions;
using DataStructures.LinkedLists.Interfaces;

namespace DataStructures.LinkedLists;

public class SinglyLinkedList<T> : IEnumerable<Node<T>>
{
    public SinglyLinkedList()
    {
        _head = Node<T>.Create(default, default);
        _tail = Node<T>.Create(default, default);
        _head.SetNext(_tail);
    }
    
    private readonly Node<T> _head;
    private readonly Node<T> _tail;
    
    public Node<T> Find(T value)
    {
        if (IsListEmpty())
        {
            throw new EmptyLinkedListExceptions("No elements in the list");
        }
        
        var currentNode = _head.Next;

        while (!currentNode.Equals(_tail))
        {
            if (currentNode.Value.Equals(value))
            {
                return currentNode;
            }

            currentNode = currentNode.Next;
        }
        
        return default;
    }

    public INode<T> GetFirst()
    {
        if (IsListEmpty())
        {
            throw new EmptyLinkedListExceptions("No elements in the list");
        }
        
        return _head.Next;
    }
    
    public INode<T> GetLast()
    {
        if (IsListEmpty())
        {
            throw new EmptyLinkedListExceptions("No elements in the list");
        }

        var currentNode = _head.Next;

        while (!currentNode.Next.Equals(_tail))
        {
            currentNode = currentNode.Next;
        }
        
        return currentNode;
    }
    
    public void AddFirst(T value)
    {
        var newNode = Node<T>.Create(value, _head.Next);
        
        _head.SetNext(newNode);
    }
    
    public void AddFirst(Node<T> node)
    {
        node.SetNext(_head.Next);
        
        _head.SetNext(node);
    }
    
    public void AddLast(T value)
    {
        var newNode = Node<T>.Create(value, _tail);

        if (_head.Next is null || _head.Next.Equals(_tail))
        {
            _head.SetNext(newNode);
            newNode.SetNext(_tail);
            return;
        }

        var currentNode = _head.Next;

        while (!currentNode.Next.Equals(_tail))
        {
            currentNode = currentNode.Next;
        }

        currentNode.SetNext(newNode);
        newNode.SetNext(_tail);
    }
    
    public void AddLast(Node<T> node)
    {
        if (IsListEmpty())
        {
            _head.SetNext(node);
            node.SetNext(_tail);
            return;
        }

        var currentNode = _head.Next;

        while (!currentNode.Next.Equals(_tail))
        {
            currentNode = currentNode.Next;
        }

        currentNode.SetNext(node);
        node.SetNext(_tail);
    }
    
    public void RemoveFirst()
    {
        if (IsListEmpty())
        {
            throw new EmptyLinkedListExceptions("No elements in the list");
        }
        _head.SetNext(_head.Next.Next);
    }
    
    public void RemoveLast()
    {
        if (IsListEmpty())
        {
            throw new EmptyLinkedListExceptions("No elements in the list");
        }
        
        var currentNode = _head.Next;

        while (!currentNode.Next.Next.Equals(_tail))
        {
            currentNode = currentNode.Next;
        }
        
        currentNode.SetNext(_tail);
    }
    
    public void Remove(T value)
    {
        if (IsListEmpty())
        {
            throw new EmptyLinkedListExceptions("No elements in the list");
        }

        var previousNode = _head;
        var currentNode = _head.Next;

        while (currentNode is not null)
        {
            if (EqualityComparer<T>.Default.Equals(currentNode.Value, value))
            {
                previousNode.SetNext(currentNode.Next); 
                return;
            }

            previousNode = previousNode.Next;
            currentNode = currentNode.Next;
        }
    }
    
    public void Remove(Node<T> node)
    {
        if (IsListEmpty())
        {
            throw new EmptyLinkedListExceptions("No elements in the list");
        }

        var previousNode = _head;
        var currentNode = _head.Next;

        while (!currentNode.Equals(node))
        {
            previousNode = previousNode.Next;
            currentNode = currentNode.Next;
        }
        
        previousNode.SetNext(currentNode.Next); 
    }
    
    private bool IsListEmpty()
    {
        return _head.Next is null || _head.Next.Equals(_tail);
    }
    
    public IEnumerator<Node<T>> GetEnumerator()
    {
        var currentNode = _head.Next;

        while (currentNode != null && currentNode != _tail)
        {
            yield return currentNode;
            currentNode = currentNode.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
}