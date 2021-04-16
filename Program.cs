using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo.ConsoleApp
{
 /*
  * Robo para Marte 2.0
  
    Input:
 
        5 5
 ----------------------------------       
        1 2 N
        EMEMEMEMM 
 -----------------------------------       
        3 3 L
        MMDMMDMDDM
    
    Output Esperado:
        1 3 N
 ----------------------------------        
        5 1 L
 */

    class Program
    {
        static void Main(string[] args)
        {
            //Área que os robos Percorrem 
            String areaRobo = "5 5";//Declaração e inicialização da váriavel area
            
            //Variaveis do Robo 1
            String posicaoInicialRobo1 = "1 2 N ";//Declaração e inicialização da variavel posicaoInicialRobo1
            String comandoRobo1 = "EMEMEMEMM";//Declaração e inicialização da variavel comandoRobo1

            //Variaveis do Robo 2
            String posicaoInicialRobo2 = "3 3 L";//Declaração e inicialização da variavel posicaoInicialRobo2
            String comandoRobo2 = "MMDMMDMDDM";//Declaração e inicialização da variavel comandoRobo2

            String[] posicoesIniciais = new string[] { posicaoInicialRobo1, posicaoInicialRobo2 };
            String[] comandosRobos = new string[] { comandoRobo1, comandoRobo2 };

            for (int i = 0; i < 2; i++)
            {
                String[] posicaoInicialSeparadaRobo = posicoesIniciais[i].Split();//Declaracao de array. Split está realizando a quebra da string posição inicial robo

                int posicaoXRobo = Convert.ToInt32(posicaoInicialSeparadaRobo[0]);//Armazena a posição x do robo na posição 0 do array posição inicial separada
                int posicaoYRobo = Convert.ToInt32(posicaoInicialSeparadaRobo[1]);//Armazena a posição y do robo na posição 1 do array posição inicial separada
                char direcaoRobo = Convert.ToChar(posicaoInicialSeparadaRobo[2]);//Armazena a direção do robo na posição 2 do array posição inicial separada

                char[] instrucoes = comandoRobo1.ToCharArray();

                //Loop
                foreach (char instrucao in instrucoes)

                {   //Move o Robo pra cima pra baixo
                    if (instrucao == 'M')
                    {
                        if (direcaoRobo == 'N')
                        {
                            posicaoYRobo++;
                        }

                        else if (direcaoRobo == 'S')
                        {
                            posicaoYRobo--;
                        }

                        else if (direcaoRobo == 'L')
                        {
                            posicaoXRobo++;
                        }

                        else if (direcaoRobo == 'O')
                        {
                            posicaoXRobo--;
                        }
                    }

                    //Vira o Robo para esquerda
                    else if (instrucao == 'E')
                    {
                        if (direcaoRobo == 'N')
                        {
                            direcaoRobo = 'O';
                        }

                        else if (direcaoRobo == 'S')
                        {
                            direcaoRobo = 'L';
                        }

                        else if (direcaoRobo == 'L')
                        {
                            direcaoRobo = 'N';
                        }

                        else if (direcaoRobo == 'O')
                        {
                            direcaoRobo = 'S';
                        }
                    }

                    //Vira o Robo para direita
                    else if (instrucao == 'D')
                    {
                        if (direcaoRobo == 'N')
                        {
                            direcaoRobo = 'L';
                        }

                        else if (direcaoRobo == 'S')
                        {
                            direcaoRobo = 'O';
                        }

                        else if (direcaoRobo == 'L')
                        {
                            direcaoRobo = 'S';
                        }

                        else if (direcaoRobo == 'O')
                        {
                            direcaoRobo = 'N';
                        }
                    }
                }

                String[] areaRoboSeparada = areaRobo.Split();//É necessário separar a váriavel areaRobo para possibilitar a validação
                int areaA = Convert.ToInt32(areaRoboSeparada[0]);//Armazena a primeira area do robo na posição 0 do array areaRoboSeparada
                int areaB = Convert.ToInt32(areaRoboSeparada[1]);//Armazena a segubda area do robo na posição 1 do array areaRoboSeparada


                //Validação da Área do Robo
                if (posicaoXRobo < 0 || posicaoXRobo > areaA || posicaoXRobo < 0 || posicaoYRobo > areaB)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rota Inválida");
                    Console.ReadLine();
                    Console.ResetColor();

                }

                else
                {
                    //Resultado
                    String resultado = $"{posicaoXRobo} {posicaoYRobo} {direcaoRobo}";/*Usando interpolação para mostrar o resultado em uma única linha*/

                    Console.WriteLine(resultado);/*Mostra o resultado*/
                    Console.ReadLine();
                }

            }


        }
    }
}
