using System;
using System.Collections.Generic;
 
 class krunker {
 
    public static IEnumerable<string> GetMyList()
    {
        List<string> listaitemow = new List<string>() {
         "Kitagawa", "JD", "XDDD", "nie" };
 

        foreach(var items in listaitemow)

            yield return items;
        }
    }

    static public void Main()
    {
        IEnumerable<string> listaSitemow = GetMyList();
 
        foreach(var i in listaSitemow)
        {
            Console.WriteLine(i);
        }
    }
}






