namespace DSA
{
    public class DoublyLinkedList
    {
        private static int count = 0;
        private DLLNode? temp;
        private DLLNode? head;
        public DLLNode? Temp { get => temp; set => temp = value; }
        public DLLNode? Head { get => head; set => head = value; }
        public static int Count { get => count; set => count = value; }
        public DoublyLinkedList()
        {
            Head = null;
            Temp = null;
        }
        public void AppendList(int data)
        {
            if (Head == null)
            {
                Head = new DLLNode(data);
                Temp = Head;
                ++Count;
            }
            else
            {
                DLLNode newNode = new DLLNode(data);
                Temp.Next = newNode;
                newNode.Prev = Temp;
                Temp = Temp.Next;
                ++Count;
            }
        }
        public void DisplayList()
        {
            if (Head != null)
            {
                DLLNode? iterator = this.Head;
                for (int i = 0; i < Count; ++i)
                {
                    Console.Write($"{iterator.Data}-");
                    iterator = iterator.Next;
                }
                Console.WriteLine();

                iterator = Temp;
                for (int i = 0; i < Count; ++i)
                {
                    Console.Write($"{iterator.Data}-");
                    iterator = iterator.Prev;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("List Is Empty");
            }
        }
        public void PrependList(int data)
        {
            if (Head == null)
            {
                Head = new DLLNode(data);
                Temp = head;
                ++Count;
            }
            else
            {
                DLLNode? oldHead = Head;
                Head = new DLLNode(data);
                Head.Next = oldHead;
                oldHead.Prev = Head;
                ++Count;
            }
        }
        public void InsertInList(int data, int pos)
        {
            DLLNode? iterator = Head;
            DLLNode? temp;
            if (pos <= Count + 1 || pos == 1)
            {
                if (Head != null)
                {
                    if (pos == 1)
                    {
                        PrependList(data);
                    }
                    else if (pos == Count + 1)
                    {
                        AppendList(data);
                    }
                    else
                    {
                        for (int i = 1; i < pos - 1; ++i)
                        {
                            // Console.Write($"{i}.{iterator.Data} - ");
                            // Console.ReadKey();
                            iterator = iterator.Next;
                        }
                        temp = iterator.Next;
                        DLLNode newNode = new DLLNode(data);
                        iterator.Next = newNode;
                        newNode.Prev = iterator;
                        iterator = iterator.Next;
                        iterator.Next = temp;
                        temp.Prev = iterator;
                        ++Count;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Position");
            }
        }
        public void RotateForward(int pos)
        {
            if (pos < count)
            {
                for (int i = 0; i < pos; ++i)
                {
                    if (Head == null || Count == 1)
                    {
                        return;
                    }

                    DLLNode temp = Head;
                    DLLNode? tempTail = null;

                    while (temp.Next != null)
                    {
                        tempTail = temp;
                        temp = temp.Next;
                    }

                    tempTail.Next = null;
                    temp.Next = Head;
                    Head.Prev = temp;
                    temp.Prev = null;
                    Head = temp;
                    Temp = tempTail;
                }
            }
        }
        public void RotateBackward(int pos)
        {
            if (pos < Count)
            {
                for (int i = 0; i < pos; ++i)
                {
                    if (Head == null || Count == 1)
                    {
                        return;
                    }
                    DLLNode temp = Head;
                    while (temp.Next != null)
                    {
                        if (Head == null || Count == 1)
                        {
                            return;
                        }
                        temp = temp.Next;
                    }
                    temp.Next = Head;
                    Head.Prev = temp;
                    temp = Head;
                    Head = Head.Next;
                    temp.Next = null;
                    Head.Prev = null;
                    Temp = temp;
                }
            }
        }
        public void DeletListNode(int pos)
        {
            if (Head != null && pos <= Count)
            {
                DLLNode temp = Head;

                if (pos == 1)
                {
                    Head = Head.Next;
                    Head.Prev = null;
                    --Count;
                }
                else if (pos == Count)
                {
                    for (int i = 0; i < pos - 2; ++i)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = null;
                    --Count;
                    Temp = temp;
                }
                else
                {
                    for (int i = 0; i < pos - 2; ++i)
                    {
                        // Console.Write($"{i}.{temp.Data} - ");
                        // Console.ReadKey();
                        temp = temp.Next;
                    }
                    if (temp.Next.Next != null)
                    {
                        DLLNode oldTemp = temp;
                        temp.Next = temp.Next.Next;
                        temp = temp.Next;
                        temp.Prev = oldTemp;
                    }
                    else
                    {
                        temp.Next = null;
                        Temp = temp;
                    }
                    --Count;
                }
            }
            else
            {
                Console.WriteLine("Out Of Bound");
            }
        }
        public void UpdateNode(int data, int pos)
        {
            if (Head != null)
            {
                DLLNode temp = Head;
                if (pos <= Count)
                {

                    for (int i = 0; i < pos - 1; ++i)
                    {
                        // Console.Write($"{i + 1}. {temp.Data}");
                        Console.ReadKey();
                        temp = temp.Next;
                    }
                    temp.Data = data;
                    Console.WriteLine("Data updated successfully.....");
                }
                else
                {
                    Console.WriteLine("List is out of bound");
                }
            }
            else
            {
                Console.WriteLine("List Is Empty");
                Console.ReadKey();
            }
        }
    }
}