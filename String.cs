Using System;
 
 
 namespace Concatnate
   {
        Class Program
		{
		    Static Void Main(string[]args)
			 {
			    String first = "Hello there!";
				String second = "How are you?";
				
				String[] arr = new string[]{"Hello ther!","How are you?","That's good to hear!","Bye!"};
				
				Console.WriteLine(string.Concat(arr));
				
				Console.Read();
				
				string str1,str2;
				Console.Write("Enter string ");
				str1 = console.ReadLine();
				str2 = str1.ToUpper();
				Console.WriteLine("Enter string {0) in upper case {1}",str1,str2);
				
			 }
			   strUpper();
			   System.Console.ReadLine();
			   
			  StringBuilder nameString = new stringBuilder();
			  newstring.Append('-', 6);
			  newstring.Append(" Here is a  title ");
			  newstring.Append('-', 6);
			  
			  newstring.AppendLine();
			  newstring.Append("And here is a paragraph!");
			  
			  newstring.Insert(0,"my  name id Anita");
			  Console.WriteLine(newstring);
			  StringBuilder anotherstring = new stringBuilder("Hi Anita!");
			  
			  anotherstring.Append("How are you today?").Appendline().Append("I am great!");
			  
			  Console.WriteLine(anotherstring);
			  			   
		}
   }