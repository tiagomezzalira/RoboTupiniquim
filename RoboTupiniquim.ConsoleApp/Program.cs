using System;

namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxX, maxY, pX, pY;
            char referenciaatual;
            string strrespostas;

            Console.Write("Digite a coordenada x do canto superior da área: ");
            maxX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a coordenada y do canto superior da área: ");
            maxY = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < 2; j++)
            {
                Console.Write("Digite a posição X inical do robô: ");
                pX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a posição Y inical do robô: ");
                pY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a direção ou referencia inicial do robô: ");
                referenciaatual = Convert.ToChar(Console.ReadLine().ToUpper());
                Console.WriteLine("Digite as instruções do robô ( Ex: MMDMM )  : ");
                strrespostas = Console.ReadLine().ToUpper();

                char[] vetrespostas = strrespostas.ToCharArray();
                for (int i = 0; i < vetrespostas.Length; i++)
                {
                    char charrespostas = vetrespostas[i];
                    switch (charrespostas)
                    {
                        case 'D':
                            switch (referenciaatual)
                            {
                                case 'N':
                                    referenciaatual = 'L';
                                    break;
                                case 'S':
                                    referenciaatual = 'O';
                                    break;
                                case 'L':
                                    referenciaatual = 'S';
                                    break;
                                case 'O':
                                    referenciaatual = 'S';
                                    break;
                            }
                            break;
                        case 'E':
                            switch (referenciaatual)
                            {
                                case 'N':
                                    referenciaatual = 'O';
                                    break;
                                case 'S':
                                    referenciaatual = 'L';
                                    break;
                                case 'L':
                                    referenciaatual = 'N';
                                    break;
                                case 'O':
                                    referenciaatual = 'S';
                                    break;
                            }
                            break;
                        case 'M':
                            switch (referenciaatual)
                            {
                                case 'N':
                                    pY = pY + 1;
                                    break;
                                case 'S':
                                    pY = pY - 1;
                                    break;
                                case 'L':
                                    pX = pX + 1;
                                    break;
                                case 'O':
                                    pX = pX - 1;
                                    break;
                            }
                            break;
                    }
                }
                Console.WriteLine(pX + " " + pY + " " + referenciaatual);

            }
        }
    }
}



