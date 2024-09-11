namespace LeetCodeSolutions.LinkedLists;
/// <summary>
/// Runtime complexity: 0(n)
/// Space complexity: 0(1)
/// Runtime: 80ms
/// Memory: 46.65 MB
/// Solution pattern: Fast and Slow pointers
/// Level: Easy
/// </summary>


public class LinkedListCycle
{
    public bool HasCycle(ListNode head) {

        if(head is null || head.next is null || head.next.next is null)
        {
            return false;
        }

        ListNode slowPointer = head;
        ListNode fastPointer = head;

        while(fastPointer is not null && fastPointer.next is not null)
        {
            slowPointer = slowPointer?.next;
            fastPointer = fastPointer?.next?.next;

            if(slowPointer == fastPointer)
            {
                return true;
            }
        }

        return false;
    }
}

//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}
