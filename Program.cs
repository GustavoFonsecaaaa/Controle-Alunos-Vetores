internal class Program
{
    private static void Main(string[] args)
    {
        int[] nota = new int[2], frequencia = new int[2];
        string[] nome = new string[2], situacao = new string[2];
        

        for (int i = 0; i < nome.Length; i++)
        {
            Console.Write("Insira o nome do " + (i + 1) + " aluno: ");
            nome[i] = (Console.ReadLine());

            Console.Write("Insira a nota do " + (i + 1) + " aluno: ");
            nota[i] = int.Parse(Console.ReadLine());

            Console.Write("Insira a frequência do " + (i + 1) + " aluno: ");
            frequencia[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nome.Length; i++)
        {
            if (nota[i] >= 60 && frequencia[i] >= 75)
            {
                situacao[i] = "Aprovado";
            }

            else
            {
                situacao[i] = "Reprovado";
            }
        }

        for (int i = 0; i < nome.Length; i++)
        {
            if (situacao[i] == "Aprovado")
            {
                Console.WriteLine($"O aluno {nome[i]} foi aprovado com {nota[i]} de nota e  de {frequencia[i]} de frequencia. (Posição do vetor{i})");
            }
        }    
        
        for(int i = 0; i < nome.Length; i++)
        {
            Console.WriteLine($" O aluno {nome[i]} com a nota de  {nota[i]} pontos com a frequencia de {frequencia[i]}% foi {situacao[i]} ");
                        
        }   
    }
}