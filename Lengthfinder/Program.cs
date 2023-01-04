// See https://aka.ms/new-console-template for more information
using System.Data;

LengthHelper inst = new LengthHelper();
var cont = 1;
while (cont ==1)
{
    Console.WriteLine("Enter the string");
    var data = Console.ReadLine();
    Console.WriteLine(inst.findLength(data));
    Console.WriteLine("Press 1 to continue 0 to cancel");
    cont = Convert.ToInt32(Console.ReadLine());
};
public class LengthHelper
{
    public int findLength(string data)
    {
        if (data ==null) throw new NullReferenceException("data cannot be null");
        var length = data.Length;
        return length;
    }
}

    

