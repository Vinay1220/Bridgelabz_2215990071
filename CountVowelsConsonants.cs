using System;

	class CountVowelsConsonants{
		
		static void Main(String[] args){
			
			Console.WriteLine("Enter a string");
			string str = Console.ReadLine();
			
			string LowerCase = str.ToLower();
			
			string Vowels = "aeiou";
			
			int VowelCount = 0;
			int ConsonantCount = 0;
			
			for(int i=0; i<LowerCase.Length; i++){
				
				char c = LowerCase[i];
				
				if(char.IsLetter(c)){
					
					if(Vowels.IndexOf(c) >=0){
						VowelCount++;
					}else{
					ConsonantCount++;
					}
				
				}
			
			}
			
			Console.WriteLine("Number of Vowel: "+VowelCount);
			Console.WriteLine("Number of Contain: "+ConsonantCount);
		
		}
	
	}