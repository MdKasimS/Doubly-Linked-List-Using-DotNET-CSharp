namespace DSA
{
    public class DLLNode
    {
        private int data;
        private DLLNode? next;
        private DLLNode? prev;
        public DLLNode? Next { get => next; set => next = value; }
        public int Data { get => data; set => data = value; }
        public DLLNode? Prev { get => prev; set => prev = value; }
        public DLLNode(int data) => Data = data;
    }
}