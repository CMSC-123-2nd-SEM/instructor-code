namespace StacknQueue
{
    public class Node<T>
    {
        // Properties also known as smart fields are the equivalent of a private field in Java with a getter and a setter
        public Node<T>? Next { get; set; }
        public T? Data { get; set; }

        public Node(T data)
        {
            this.Data = data;
            this.Next = null;
        }
        public Node(){}
    }
}