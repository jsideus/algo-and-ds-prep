public class MergeTwoSortedLinkedLists
{

    public ListNode MergeTwoSortedLnkdLists(ListNode list1, ListNode list2)
    {
        var mergedListNode = new ListNode(0);
        var current = mergedListNode;

        while (list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        
        if(list1 != null)
        {
            current.next = list1;
        }
        else
        {
            current.next = list2;
        }

        return mergedListNode.next;

    }
}