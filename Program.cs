// See https://aka.ms/new-console-template for more information
class PemrosesanData
{
    public void DapatkanNilaiTerbesar<T> (T t1, T t2, T t3) 
    {
        dynamic a1 = t1;
        dynamic a2 = t2;
        dynamic a3 = t3;

        if (a1 > a2 && a1 > a3)
        {
            Console.WriteLine($"{t1}");

        }
        else if (a2 > a1 && a2 > a3)
        {
            Console.WriteLine($"{t2}");
        }
        else if (a3 > a1 && a3 > a2)
        {
            Console.WriteLine($"{t3}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        PemrosesanData prosesData = new PemrosesanData();
        int a = 10;
        int b = 30;
        int c = 22;

        prosesData.DapatkanNilaiTerbesar(a, b, c);
    }
}