namespace StacknQueue
{
    public class BananaQ<T>
    {
        private Node<T>? front;
        private Node<T>? rear;
        public BananaQ(){
            front = null;
            rear = null;
        }
        public void Enqueue(T data)
        {
            //implement adding to queue
            if(front == null) {
                front = new Node<T>(data); // if the queue is empty, make the front and rear the same
                rear = front;
            } else {
                Node<T> temp = new Node<T>(data); // else, make the new node point to the rear
                rear.Next = temp;
                rear = temp;
            }

        }

        public T Dequeue()
        {
            // implement removing from a queue
            Node<T> temp = front;
            front = front.Next;
            return temp.Data;
        }
    }
}