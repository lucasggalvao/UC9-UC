string[,] cad = new string[1,3];
int l, c; 

l = 0;
c = 0;

for (l = 0; l < 1; l++)
{
    c = 0;

    Console.WriteLine("Informe o numero da UC: ");
    cad[l,c++] = Console.ReadLine();
    Console.WriteLine("Informe a descrição da UC: ");
    cad[l, c++] = Console.ReadLine();
    Console.WriteLine("Informe a carga horária da UC: ");
    cad[l, c++] = Console.ReadLine();
    Console.WriteLine("Informe a duração da aula: ");
    cad[l, c++] = Console.ReadLine();


}



