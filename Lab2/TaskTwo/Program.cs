// See https://aka.ms/new-console-template for more information
        Console.WriteLine("Vvedite chislo: ");
string N_Str = Console.ReadLine();
int x = 0, NN, N = Convert.ToInt32(N_Str);
        NN = N;
    while (NN > 0)
    {
        NN = NN / 10;
        x++;
    } 
    
    if (x >= 3)
    {
        int[] a = new int[x];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = N % 10;
                N = N / 10;
            }
                Console.WriteLine($"3 cifra = {a[^3]}");
    }     
    else Console.WriteLine("Net 3 cifr v chisle");
Console.WriteLine("#КОГДА UNREAL ENGINE 4? ;)");
