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
        this.backingArray = new T[4];
        this.size = 4;
        this.lastIndex = 0;
    }
    
    // Method to get element from backing array at index i
    public T GetElementAtIndex(int index){
        if(index > lastIndex) throw new IndexOutOfRangeException();
        return backingArray[index];
    }

    public void Add(T newElement)
    {
        if(lastIndex==size) {
            // resize your arraylist, copy over elements to new backing array 
            this.size = 2*this.size;
            T[] newArray = new T[size];
            for(int i = 0; i < backingArray.Length; i++)
            {
                newArray[i] = backingArray[i];
            }
            backingArray = newArray;
        }
        // add elements to backing array
        backingArray[lastIndex] = newElement;
        Console.WriteLine("Adding element");
        lastIndex++;
    }

    public bool Find(T element2Find)
    {
        foreach(T element in backingArray)
        {
            if(element.Equals(element2Find)) return true;
        }
        return false;
    }

    public int GetSize(){
        return this.size;
    }

    public int GetCapacity(){
        return lastIndex + 1;
    }
}
