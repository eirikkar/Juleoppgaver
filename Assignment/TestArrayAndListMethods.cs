using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;
using Xunit.Sdk;

/*
Tester skrevet av: https://github.com/jorgenmjobloop
*/

public class TestArrayAndListMethods : AssignmentBase
{
    public string[] StringArray(string[] arr)
    {
        throw new NotImplementedException();
    }

    public int[] IntSum(int a, int b)
    {
        throw new NotImplementedException();
    }

    public List<string> LoopList(List<string> element)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Implement a simple Dictionary method
    /// </summary>
    /// <param name="element"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Dictionary<int, string> LoopDict(Dictionary<int, string> element)
    {
        throw new NotImplementedException();
    }

    public string ReverseString(string arr)
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Description of Binary Search algorithm:
    /// Steps:
    /// 1: decide left side: set this to 0
    /// 2: decide right side: take the length of the array parameter and subtract one from it like so:
    /// int right = arr.Length - 1
    /// check whether or not left side is less than or equal to right side.
    /// </summary>
    /// <param name="arr">input array</param>
    /// <param name="x">x value to find within the array</param>
    /// <returns></returns>
    /// <exception cref="NullException"></exception>
    /// <exception cref="NotImplementedException"></exception>
    public int BinarySearch(int[] arr, int x)
    {
        // Array.Sort(arr);
        if (x == -1 || arr == null)
        {
            throw new NullException("Array must be sorted before algorithm can be implemented!");
        }
        throw new NotImplementedException();
    }

    [Assignment(1)]
    public void ShouldReturnStringArray()
    {
        string[] expected = new string[25];
        Assert.Equal(expected, StringArray(expected));
    }
    [Assignment(2)]
    public void ShouldReturnSumOfIntArray()
    {
        int[] sum = new int[3];
        Assert.Equal(sum, IntSum(1, 2));
    }
    [Assignment(3)]
    public void ShouldReturnANewElementInList()
    {
        List<string> expected = new List<string>();
        for (int i = 0; i < 15; i++)
        {
            Assert.Equal(expected, LoopList(expected));
        }
    }
    [Assignment(4)]
    public void ShouldReturnANewDictionary()
    {
        Dictionary<int, string> expected = new Dictionary<int, string>() {
            {1,""}, {2,"Hello World!"}, {3, "foo"}, {4, "bar"}, {5, "foo"}, {6, "baz"}
        };
        for (int i = 0; i < 10; i++)
        {
            Assert.Equal(expected, LoopDict(expected));
        }
    }
    [Assignment(5)]
    public void TestReverseString()
    {
        string input = "Foo, Baz";
        string str = ReverseString(input);
        char[] sample = str.ToCharArray();
        sample.Reverse();
        Assert.Equal(sample, ReverseString(input));
    }

    [Assignment(6)]
    public void TestBinarySearchMethod()
    {
        int[] expectedXValues = { 1, 2, 3, 4, 5, 6, 8, 9, 10, 25, 99, 91 };
        int[] samplePool = {
            1,2,3,4,5,6,7,8,9,10,12,24,32,48,56,64,128,256,512,1024,2048, 1213, 1440, 2414, 93, 01, 23,
        };

        for (int i = 0; i < samplePool.Count(); i++)
        {
            for (int j = 0; j < expectedXValues.Length; j++)
            {
                Assert.DoesNotContain(BinarySearch(samplePool, expectedXValues[i]), expectedXValues);
                Assert.Equal(expectedXValues[j], BinarySearch(samplePool, expectedXValues[j]));
            }
        }

    }
}