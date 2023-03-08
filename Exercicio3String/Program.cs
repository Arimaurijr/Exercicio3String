internal class Program
{
    private static void Main(string[] args)
    {
            string palavra;
            char caractere;

            Console.WriteLine("INFORME UMA PALAVRA: ");
            palavra = Console.ReadLine().ToLower();
            //palavra = palavra.ToLower();

            Console.WriteLine("INFORME UM CARACTERE: ");
            caractere = char.Parse(Console.ReadLine());

            char[] vetores_caracteres = new char[2 * (palavra.Length)];

            /*
            int j = 0;
              for(int i = 0; i < palavra.Length; i++)
              {
                      if(palavra[i] != 'a' && 
                         palavra[i] != 'e' && 
                         palavra[i] != 'i' && 
                         palavra[i] != 'o' && 
                         palavra[i] != 'u')
                      {
                            vetores_caracteres[j] = caractere;
                            j++;
                            vetores_caracteres[j] = palavra[i];

                            //vetores_caracteres[j] = palavra[i];
                      }
                      else
                      {
                            vetores_caracteres[j] = palavra[i]; 
                      }

                      j++;
              }
            */

        char[] ColocarCaractereAntesConsoante(string palavra, char caractere)
        {
            int j = 0;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] != 'a' &&
                    palavra[i] != 'e' &&
                    palavra[i] != 'i' &&
                    palavra[i] != 'o' &&
                    palavra[i] != 'u')
                {
                    vetores_caracteres[j] = caractere;
                    j++;
                    vetores_caracteres[j] = palavra[i];

                    //vetores_caracteres[j] = nome[i];
                }
                else
                {
                    vetores_caracteres[j] = palavra[i];
                }

                j++;
            }

            return vetores_caracteres;
        }

             vetores_caracteres = ColocarCaractereAntesConsoante(palavra,caractere);
             string resultado = string.Concat(vetores_caracteres);

             Console.Write(resultado);
     }
}