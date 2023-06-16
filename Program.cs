Console.Clear();
Console.WriteLine ("Digite um numero para tabuada: ");


int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int y = 0;
int produto;
while (y<=10)
{
   produto = x * y;
   Console.WriteLine ($"{x} X {y}= {produto}");
    y ++;
}