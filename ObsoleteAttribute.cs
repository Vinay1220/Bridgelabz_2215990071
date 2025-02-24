using System; 
 
class LegacyAPI 
{ 
    [Obsolete("OldFeature is deprecated, use NewFeature 
instead.")] 
    public void OldFeature() 
    { 
        Console.WriteLine("This is the old feature."); 
    } 
 
    public void NewFeature() 
    { 
        Console.WriteLine("This is the new feature."); 
    } 
} 
 
class Program 
{ 
    static void Main() 
    { 
        LegacyAPI api = new LegacyAPI(); 
        api.OldFeature(); // This will show a warning 
        api.NewFeature(); 
    } 
} 
 
Exercise 3: Suppress Warnings for Unchecked Op