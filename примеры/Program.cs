// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] chisla = { 1, 5, 6, 9, -10 };
int result=0;

foreach(int ch in chisla)
{
  if (ch > 0)
  {
        result++;
        Console.WriteLine(ch);
   }
 
}