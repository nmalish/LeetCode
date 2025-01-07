namespace BinarySearchTests;

public class BinarySearchTests
{
    [Fact]
    public void Compare_Search()
    {
        int[] data = Enumerable.Repeat(0, 500).Select(i => i - 250).ToArray();
        Random rnd = new Random();
        int value = rnd.Next(-250, 250);

        int index1 = Array.IndexOf(data, value);

        BinarySearch binarySearch = new();
        int index2 = binarySearch.MySearch(data, value);

        Assert.Equal(index1, index2);
    }

    [Fact]
    public void Search_EqualToDefault()
    {
        int low = 0;
        const int high = 10;
        const int length = 10;
        Random rnd = new Random();
        int[] data = Enumerable
            .Repeat(0, length)
            .Select(i => rnd.Next(low, high))
            .OrderBy(i => i)
            .ToArray();

        int value = data[rnd.Next(0, length)];

        int index1 = Array.IndexOf(data, value);

        BinarySearch binarySearch = new();
        int index2 = binarySearch.MySearch(data, value);

        Assert.Equal(index1, index2);
    }

    [Fact]
    public void SearchWhileIndexNotEqual()
    {
        int low = 0;
        const int high = 10;
        const int length = 10;
        Random rnd = new Random();
        while (true)
        {
            int[] data = Enumerable
                .Repeat(0, length)
                .Select(i => rnd.Next(low, high))
                .OrderBy(i => i)
                .ToArray();

            int value = data[rnd.Next(0, length)];

            int index1 = Array.IndexOf(data, value);

            BinarySearch binarySearch = new();
            int index2 = binarySearch.MySearch(data, value);

            if (index1 != index2)
            {
                Assert.NotEqual(index1, index2);
            }
        }
    }
}