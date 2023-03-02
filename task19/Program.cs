Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a>9999 && a<100000)
{
String a1 = Convert.ToString(a);
if(a1[0]== a1[4] && a1[1]==a1[3])
{
    Console.WriteLine(a + " - это число палиндром!");
}else{
    Console.WriteLine(a + " - это число не палиндром!");
}

}else{
    Console.WriteLine("Вы ввели не пятизначное число!");
}