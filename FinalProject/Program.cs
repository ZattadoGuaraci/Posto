using System.Numerics;

namespace FinalProject
{
    internal class Program
    {
        //o que falta: Finalizar a primeira opção, quando entrar na opção Flex
        // terminar a segunda opção do menu principal.
            // para isso, usar objetos p/ armazenar os valores lidos nas variaveis tals............. E nesse caso nem preciso da função stringToFloat, ja que posso ter um método interno para tratar os dados que recebo

        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo(a) ao Sistema de cálculo do combustível mais econômico para seu veículo");
                Console.WriteLine("\nEscolha uma das opções abaixo: \n\n 1 - Calcular Combustível\n 2 - Editar Dados \n 3 - Encerrar Programa");
                string opcaoMenu = Console.ReadLine();


                float autonomiaAlcoolParsed;
                float autonomiaGasolinaParsed;

                bool isParsable = Int32.TryParse(opcaoMenu, out number);

                if (isParsable)
                {

                    Console.WriteLine("Opção Selecionada -> " + number);
                    switch (number)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Escolha a opção referente ao tipo de combustível utilizado pelo seu veículo: \n1 - Álcool\n2 - Gasolina\n3 - Flex");
                            string selection = Console.ReadLine();
                            int result = stringToInteger(selection);
                            switch (result)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("O melhor combustível para seu veículo é Álcool");
                                    Console.Write("\n\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.Clear();
                                    Console.WriteLine("O melhor combustível para seu veículo é Gasolina");
                                    Console.Write("\n\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Qual o preço do Etanol?: ");
                                    string precoEtanol = Console.ReadLine();
                                    Console.WriteLine("Qual o preço da Gasolina?: ");
                                    string precoGasolina = Console.ReadLine();

                                    float precoGasolinaParsed = stringToFloat(precoGasolina, 2);
                                    float precoEtanolParsed = stringToFloat(precoGasolina, 2);

                                    float percentual = ((float)(0.7 / precoGasolinaParsed));
                                    if(percentual > precoEtanolParsed)
                                    {
                                        //compensa etanol 
                                        Console.WriteLine("Compensa Etanol");
                                        Console.WriteLine(percentual);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Compensa Gasolina");
                                        Console.WriteLine(percentual);

                                    }


                                    Console.Write("\n\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Opção Inválida");
                                    Console.Write("\n\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();

                                    break;

                            }
                            Console.WriteLine(result);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\nFazer um sub-menu acima...\n3- Flex:\nDigite a autonomia do seu veículo no álcool");
                            string autonomiaAlcool;
                            autonomiaAlcool = Console.ReadLine();
                            autonomiaAlcoolParsed = stringToFloat(autonomiaAlcool, 2);
                            Console.WriteLine(autonomiaAlcoolParsed);
                            Console.WriteLine("\nFazer um sub-menu acima...\n3- Flex:\nDigite a autonomia do seu veículo na Gasolina");
                            string autonomiaGasolina;
                            autonomiaGasolina = Console.ReadLine();
                            autonomiaGasolinaParsed = stringToFloat(autonomiaGasolina, 2);
                            Console.WriteLine(autonomiaGasolinaParsed);
                            break;
                        case 3:
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção Inválida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Digite Apenas os números informados no menu."); // colocar um timer de uns 3s, e depois redirecionar para o início
                    return;
                }


            } while (number != 3);


         
        }
        public static Int32 stringToInteger(string s)
        {
            int number;

            bool isParsable = Int32.TryParse(s, out number);

            if (isParsable)
            {
                return number;
            }
            else
            {
                return 0;
            }
        }

        public static float stringToFloat(string s, int qtd)
        {
            float number;

            bool parsable = float.TryParse(s, out number);
            if (parsable)
            {
                return number;
            }
            else
            {
                return 0;
            }
        }
    }
}

//https://github.com/ZattadoGuaraci/Posto