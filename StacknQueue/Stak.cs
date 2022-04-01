namespace StacknQueue
{
    public class Stak<T>
    {
        private Node<T>? top;
        public Stak(){
            top = null;
        }
        public void Push(T data)
        {
            // implement adding to the stack
            if(top != null){ // check if top is empty
                Node<T> temp = new Node<T>(data); // create temp node to hold data
                temp.Next = top; // set the temp next node to old top
                top = temp; // set new top to new node
            } else {
                top = new Node<T>(data);
            }
        }

        public T Pop()
        {
            // implement deleting from the stack
            Node<T> temp = top; // set temp node to  old top 
            top = top.Next; // set top to old top next node
            return temp.Data; // return data
        }

        public T Peek()
        {
            //implement peeking from the top of the stack
            return top.Data; // return data of top node
        }
    }
}