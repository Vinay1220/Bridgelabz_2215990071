using System;

	class StringReverse{
		
		static void Main(String[] args){
			
			Console.WriteLine("Enter a string ");
			String str = Console.ReadLine();
			
			char[] charArray = str.ToCharArray();
			
			for(int i=0, j=charArray.Length-1; i<j; i++,j--){
				
				char temp = charArray[i];
				charArray[i] = charArray[j];
				charArray[j] = temp;
			
			} 
			string ReversedString = new string(charArray);
			
			Console.WriteLine("ReversedString String: "+str+" => "+ ReversedString);
		
		}
	
	}