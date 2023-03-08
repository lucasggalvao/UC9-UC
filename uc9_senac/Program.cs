string[,] cad = new string[1,3];
string opcao;
int l, c; 

l = 0;
c = 0;

for (l = 0; l < 1; l++)
{
    Console.WriteLine("Qual a UC que deseja pesquisar?: ");
    cad[l,c++] = Console.ReadLine();
    Console.WriteLine("Descrição: ");
    cad[l, c++] = Console.ReadLine();
    Console.WriteLine("sua carga horária é de: ");
    cad[l, c++] = Console.ReadLine();

    
}

Console.WriteLine("Qual a duração da sua aula? ");
Console.ReadLine();
