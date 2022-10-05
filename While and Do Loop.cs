using System;

namespace While Loop
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 5) 
      {
        Console.WriteLine(i);
        i++;
		
		do 
        {
        Console.WriteLine(i);
        i++;
        }
      while (i < 5);
	  
      }
    }
  }
}