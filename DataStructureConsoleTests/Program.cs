

// Example: Create a linked list with values [1, 2, 3, 4, 5] and a cycle starting at index 2 (value 3)

LinkedListWithCycle linkedList = new LinkedListWithCycle(new int[] { 1,2}, 0);

// The list will have a cycle: 1 -> 2 -> 3 -> 4 -> 5 -> (points back to 3)
ListNode head = linkedList.Head;

var length = FindCycleLength(head);
var result = HasCycle(head);
var node = FindCycleStart(head);

Console.WriteLine();

ListNode FindCycleStart(ListNode head)
{
    ListNode slow = head;
    ListNode fast = head;

    while (fast is not null && fast.Next is not null)
    {
        slow = slow.Next;
        fast = fast.Next.Next;

        if (slow == fast)
        {
            break;
        }
    }

    slow = head;
    while (slow != fast)
    {
        if (slow == fast)
        {
            return slow;
        }

        slow = slow.Next;
        fast = fast.Next;
    }

    return null;
}

// Optional: Implement a cycle detection algorithm here to verify the cycle
bool HasCycle(ListNode head)
{
    if (head is null || head.Next is null || head.Next.Next is null)
    {
        return false;
    }

    ListNode slowPointer = head;
    ListNode fastPointer = head;

    while (fastPointer is not null &&
            fastPointer.Next is not null)
    {
        slowPointer = slowPointer.Next;
        fastPointer = fastPointer.Next.Next;
        
        if (slowPointer == fastPointer)
        {
            return true;
        }
    }

    return false;
}

int FindCycleLength(ListNode head)
{
    if (head?.Next is null
        || head.Next.Next is null)
    {
        return 0;
    }
    

    ListNode slowPointer = head;
    ListNode fastPointer = head;

    while (fastPointer is not null && fastPointer.Next is not null)
    {
        slowPointer = slowPointer.Next;
        fastPointer = fastPointer.Next.Next;

        if (slowPointer == fastPointer)
        {
            return CalculateCycleLength(slowPointer);
        }
    }

    return 0;
}

int CalculateCycleLength(ListNode slow)
{
    ListNode current = slow;

    int cycleLength = 1;

    slow = slow.Next;
    while (current != slow)
    {
        slow = slow.Next;
        cycleLength++;
    }

    return cycleLength;
}

public class ListNode
{
    public int Value { get; set; }
    public ListNode Next { get; set; }

    public ListNode(int value)
    {
        Value = value;
        Next = null;
    }
}



public class LinkedListWithCycle
{
    public ListNode Head { get; private set; }

    public LinkedListWithCycle(int[] values, int cycleIndex)
    {
        if (values.Length == 0) return;

        ListNode current = null;
        ListNode cycleEntryNode = null;

        for (int i = 0; i < values.Length; i++)
        {
            ListNode newNode = new ListNode(values[i]);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                current.Next = newNode;
            }

            current = newNode;

            // Save the cycle entry node
            if (i == cycleIndex)
            {
                cycleEntryNode = current;
            }
        }

        // Create the cycle
        if (cycleEntryNode != null)
        {
            current.Next = cycleEntryNode;
        }
    }
}