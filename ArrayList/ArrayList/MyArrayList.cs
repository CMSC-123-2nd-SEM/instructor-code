/// <summary>
/// My Arraylist implementation
/// </summary>
/// <typeparam name="T"></typeparam>
public class MyArrayList<T>
{
    /// <summary>
    /// Contains the elements of your list
    /// </summary>
    private T[] backingArray;

    /// <summary>
    /// size of my arraylist
    /// </summary>
    private int size;
    private int lastIndex;
    // Setup initial array with size 4
    public MyArrayList(){
        this.backingArray = new T[4]();
        this.size = 4;
        this.lastIndex = 0;
    }
    
    // Method to get element from backing array at index i
    public T GetElementAtIndex(int index){
        if(index >= size) throw new IndexOutOfRangeException();
        throw new NotImplementedException();
    }

    public void Add(T newElement)
    {
        if(lastIndex==size) {
            // resize your arraylist, copy over elements to new backing array 
            this.size = 2*this.size;
        }
        // add elements to backing array
        Console.WriteLine("Adding element");
        lastIndex++;
    }

    public bool Find(T element2Find)
    {
        throw new NotImplementedException();
    }

    public int GetSize(){
        return this.size;
    }

    public int GetCapacity(){
        throw new NotImplementedException();
    }
}
