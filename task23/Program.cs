Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(a + " -> ");

for(int i=1; i<=a; i++)
{
    Console.Write(i*i*i +" ");
}
