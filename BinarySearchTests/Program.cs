int[] myArray = { 1, 2, 3, 4, 5, 6 };
BinarySearch binarySearch = new();
int indexOf = binarySearch.Search(myArray, 3);

Console.WriteLine(indexOf);

Console.ReadLine();


public class BinarySearch
{
    // private readonly int[] data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    // private const int value = 7;

    // [Benchmark]
    public virtual int MySearch(int[] data, int value)
    {
        int index = -1;
        int low = 0;
        int high = data.Length - 1;
        while (low < high)
        {
            int head = (low + high) / 2;
            int current = data[head];
            
            if (current == value) return head;
            if (value > current)
                low = head ; // head + 1 // TAKE INTO ACCOUNT THAT WE already checked head
            else
                high = head; // head - 1
        }

        return index;
    }
    
    // BinarySearchRecursion
    public int Search(int[] data, int value, int low, int high)
    {
        int mid = (low + high) / 2;
        int current = data[mid];
        if (current == value) return mid;
        if (value > current)
        {
            return Search(data, value, mid + 1, high);
        }
        return Search(data, value, low, mid - 1);
    }

    public int Search(int[] data, int value)
    {
        return Array.IndexOf(data, value);
    }
}
