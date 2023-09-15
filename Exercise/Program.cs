using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // //Operador ternario
        // bool check=false;
        // Console.WriteLine(check ? "Encendido":"Apagado");
        // /* -----------------Arreglos------------------ */
        // // Acceso a elementos de un arreglo
        // int[] numeros = {30,40,50,10,20};
        // foreach (int iterador in numeros)
        // {
        //     Console.WriteLine($"{iterador}");
        // }
        // // Metodo Length
        // Console.WriteLine(numeros.Length); // Imprime el tamaño de un arreglo
        // // Metodo Sort
        // Array.Sort(numeros); // Ordena el arreglo de forma ascendente
        // foreach (int iterador in numeros)
        // {
        //     Console.WriteLine($"{iterador}");
        // }
        // // Array.IndexOf() Posicion del primer elemento con dicho valor
        // Console.WriteLine(Array.IndexOf(numeros,50));
        // // Array.Copy() Copia los elementos de un arreglo a otro
        // int[] arreglo_2 = new int[5];
        // Array.Copy(numeros,arreglo_2,5);
        // foreach (int iterador in arreglo_2)
        // {
        //     Console.WriteLine($"{iterador}");
        // }
        /* ------------------ArrayList-------------------- */
        // Contains
        // ArrayList subjects = new ArrayList {"Primera", "Segundo", "Tercera"};
        
        // Console.WriteLine(subjects.Contains("Primera") ? "Si esta": "No esta"); 
        // // Verifica si un elemento esta en el List o ArrayList
        // // Remove 
        // subjects.Remove("Primera"); // Elimina el primer elemento con dicho valor
        // foreach (Object iterador in subjects)
        // {
        //     Console.WriteLine($"{iterador.ToString()}");
        // }
        // -------------------LinQ------------------------
        var frutas = new string[] {"Sandia","Fresas", "Mango", "Ciruelas", "Mango Azucar"};
        var lstMangos = frutas.Where(p=> p.StartsWith("Mango")).ToList();
        lstMangos.ForEach(item => Console.WriteLine(item));

    }
}