namespace GruppUppgift1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Välj problem: ");
        int problem = Int32.Parse(Console.ReadLine());
        switch (problem)
        {
            case 1:
                Problem1.Run();
                break;
            case 2:
                Problem2.Run();
                break;
            case 3:
                Problem3.Run();
                break;
            case 4:
                Problem4.Run();
                break;
            case 5:
                Problem5.Run();
                break;
        }
    }
}
