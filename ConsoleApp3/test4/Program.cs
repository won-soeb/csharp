//#1
//using System;

////일반화 클래스
//class DataStore<T> {
//    private T[] s = new T[10];
//public T this[int index]
//{
//   get
//    {
//        if (index < 0 || index >= s.Length)
//            throw new IndexOutOfRangeException("Cannot store more than 10 objects");
//        return s[index];
//    }
//    set
//    {
//        if (index < 0 || index >= s.Length)
//            throw new IndexOutOfRangeException("Cannot store more than 10 objects");
//        s[index] = value;
//    }
//}
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        DataStore<string> ds1 = new DataStore<string>();
//        ds1[0] = "One";
//        ds1[1] = "Two";
//        ds1[2] = "Three";
//        for (int i = 0; i < 3; i++)
//            Console.WriteLine(ds1[i]);
//        DataStore<int> ds2 = new DataStore<int>();
//        ds2[0] = 1;
//        ds2[1] = 2;
//        ds2[2] = 3;

//        for (int i = 0; i < 3; i++)
//            Console.WriteLine(ds2[i]);
//       // ds2[11] = 11;
//    }
//}

//#2
using System;

class DataStore
{
    private string[] strArr = new string[10]; // internal data storage
    public DataStore() { }
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Cannot store more than 10 objects");
            return strArr[index];
        }
        set
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Cannot store more than 10 objects");
            strArr[index] = value;
        }
    }
    public string this[string s]
    {
        get
        {
            foreach (index in strArr)//
            {
                if (s.ToLower() == name.ToLower())
                    return s;
            }
            return null;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        DataStore strStore = new DataStore();
        strStore[0] = "One";
        strStore[1] = "Two";
        strStore[2] = "Three";
        strStore[3] = "Four";

        Console.WriteLine(strStore["one"]);
        Console.WriteLine(strStore["two"]);
        Console.WriteLine(strStore["Three"]);
        Console.WriteLine(strStore["FOUR"]);
    }
}