// See https://aka.ms/new-console-template for more information
// class Program 
// {
//   public static void Display<T>(T i)
//   {
//     Console.WriteLine("This is the value" + i);
//   }
//   static void Main(string[] args)
//   {
//     Display<int>(1);
//     Display<double>(1.1);
//     Console.Read();
//   }
// }
// namespace Demo
// {
//   public class GenericSet<T>
//   {
//     private T[] array;
//     public GenericSet(int size)
//     {
//       array = new T[size +1];
//     }
//     public T getItem(int index)
//     {
//       return array[index];
//     }
//     public void setItem(int index, T value)
//     {
//       array[index] = value;
//     }
//   }
//   class Program
//   {
//     static void Main (string[] args)
//     {
//       GenericSet<int> gn = new GenericSet<int>(2);
//       gn.setItem(1,1);
//       gn.setItem(2,2);
//       Console.WriteLine("The number one is " + gn.getItem(1));
//       Console.WriteLine("The number tw0 is " + gn.getItem(2));
//     }

//   }
// }

// public class Program
// {
//   public static void Main(string[] args)
//   {
//     List<int> myRows = new List<int>();
//     myRows.Add(11);
//     myRows.Add(22);
//     myRows.Add(33);

//     foreach(var i in myRows)
//     {
//       Console.WriteLine("Number" + i + "in the House!");
//     }
//   }
// }
namespace Program
{
  public static class MathExp
  {
    public static T Max<T>(T first, params T[] values)
    where T : IComparable
    {
      T max = first;
      foreach(var item in values)
      {
        if(item.CompareTo(max) > 0)
        {max = item;}
      }
      return max;
    }
    public static T Min<T>(T first, params T[] values)
    where T : IComparable
    {
      T min = first;
      foreach(var item in values)
      {
        if(item.CompareTo(min) < 0)
        {min = item;}
      }
      return min;
    }
  }
}