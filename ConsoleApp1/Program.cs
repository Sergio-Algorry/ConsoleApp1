Console.WriteLine("Hello, World!");

int[] var=new int[5];
var[0] = 1;
var[1] = 2;
var[2] = 3;
var[3] = 4;
var[4] = 5;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(var[i]);
}
Console.WriteLine("\r\n" + "\r\n" + "\r\n" + "Opcion Foreach" + "\r\n");

foreach (int renglon in var)
{
    Console.WriteLine(renglon);
}