// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Mediante un ciclo, pedir 11 letras, tomar la 1era, 4ta, 6ta, 9na y 11va,
//y formar una palabra concatenándolas en SENTIDO INVERSO.
Console.WriteLine("Mediante un ciclo, pedir 11 letras, tomar la 1era, 4ta, 6ta, 9na y 11va, y formar una palabra concatenándolas en SENTIDO INVERSO.");
//Datos de entrada
char[] letras = new char[11];
//Procedimiento capturar 11 letras
for (int i = 0; i < letras.Length; i++)
{
    Console.WriteLine("Captura tu letra No. " + (i+1));
    letras[i] = Convert.ToChar(Console.ReadLine());
}
Console.WriteLine($"La palabra ordenada según la posición de tus letras es {letras[0]}{letras[3]}{letras[5]}{letras[8]}{letras[10]}");
Console.WriteLine($"La misma palabra pero en orden inverso es {letras[10]}{letras[8]}{letras[5]}{letras[3]}{letras[0]}");