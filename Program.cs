using System;
namespace console_programlama
{ 
    class Program
    {
        static void Main(string[] args)//
        {
            int time=DateTime.Now.Hour;
            if(time>=6 && time<11)
            
                Console.WriteLine("gündüz");
            
            
            else if(time<=18)
            
                Console.WriteLine("iyi günler");
            else
            
                Console.WriteLine("gece");
            string sonuc=time<=18 ? "iyi günler": "iyi geceler";
            sonuc=time>=6 && time<11 ?  "günaydın":time<=18 ? "iyi günler":"gece";
            Console.WriteLine(sonuc);

            
           
        }
    }
}

