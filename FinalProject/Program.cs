using System.Numerics;
using System.Runtime.CompilerServices;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool configurado = false;
            string res = "";
            Carro veiculo = new Carro();

            do
            {
                Console.Clear();
                Console.WriteLine("Menu Inicial :\nBem vindo(a) ao Sistema de cálculo do combustível mais econômico para seu veículo");
                Console.WriteLine("\nEscolha uma das opções abaixo: \n\n 1 - Calcular Combustível\n 2 - Editar Dados \n 3 - Encerrar Programa");
                string opcaoMenu = Console.ReadLine();
                float autonomiaAlcoolParsed;
                float autonomiaGasolinaParsed;
                bool isParsable = Int32.TryParse(opcaoMenu, out number);

                if (isParsable)
                {
                    switch (number)
                    {
                        case 1:
                            int result;
                            Console.Clear();
                            Console.WriteLine("Menu Inicial > Calcular Combustível :\nEscolha a opção referente ao tipo de combustível utilizado pelo seu veículo: \n1 - Etanol\n2 - Gasolina\n3 - Flex \n\n4-Voltar ao menu anterior");
                            if (!configurado)
                            {
                                string selection = Console.ReadLine();
                                result = stringToInteger(selection);
                            }
                            else
                            {
                                result = 3;
                            }
                            switch (result)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Menu Inicial > Calcular Combustível > Resultado :\nO melhor combustível para seu veículo é Etanol");
                                    Console.Write("\n\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.Clear();
                                    Console.WriteLine("Menu Inicial > Calcular Combustível > Resultado :\nO melhor combustível para seu veículo é Gasolina");
                                    Console.Write("\n\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();
                                    break;
                                case 3:

                                    if (configurado)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu Inicial > Calcular Combustível > Flex :\nQual o preço do Etanol?: ");
                                        string precoEtanol = Console.ReadLine();
                                        Console.WriteLine("Qual o preço da Gasolina?: ");
                                        string precoGasolina = Console.ReadLine();


                                        float precoGasolinaParsed = stringToFloat(precoGasolina, 2);
                                        float precoEtanolParsed = stringToFloat(precoEtanol, 2);

                                        if (precoGasolinaParsed <= 0 || precoEtanolParsed <= 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Valores inválidos");
                                            Console.Write("\n\nPressione enter para voltar ao menu\n");
                                            Console.ReadLine();
                                            break;
                                        }

                                        float percentual = veiculo.autonomiaEtanol / veiculo.autonomiaGasolina;
                                        if ((percentual * precoGasolinaParsed) > precoEtanolParsed)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"Menu Inicial > Calcular Combustível > Resultado :\nCompensa Etanol");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"Menu Inicial > Calcular Combustível > Resultado :\nCompensa Gasolina");
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Menu Inicial > Calcular Combustível> Flex:\nQual o preço do Etanol?: ");
                                        string precoEtanol = Console.ReadLine();
                                        Console.WriteLine("Qual o preço da Gasolina?: ");
                                        string precoGasolina = Console.ReadLine();

                                        float precoGasolinaParsed = stringToFloat(precoGasolina, 2);
                                        float precoEtanolParsed = stringToFloat(precoEtanol, 2);

                                        if (precoGasolinaParsed <= 0 || precoEtanolParsed <= 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Valores inválidos");
                                            Console.Write("\n\nPressione enter para voltar ao menu\n");
                                            Console.ReadLine();
                                            break;
                                        }

                                        float percentual = ((float)(0.7 * precoGasolinaParsed));
                                        if (percentual > precoEtanolParsed)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"Menu Inicial > Calcular Combustível > Resultado :\nCompensa Etanol");

                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"Menu Inicial > Calcular Combustível > Resultado :\nCompensa Gasolina");

                                        }


                                    }

                                    Console.Write("\n\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Opção Inválida");
                                    Console.Write("\n\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        case 2:

                            Console.Clear();
                            string autonomiaAlcool;
                            Console.WriteLine("Menu Inicial > Editar Dados > Flex :\nDigite a autonomia do veículo no Etanol");
                            autonomiaAlcool = Console.ReadLine();
                            autonomiaAlcoolParsed = stringToFloat(autonomiaAlcool, 2);
                            Console.WriteLine("Digite a autonomia do seu veículo na Gasolina");
                            string autonomiaGasolina;
                            autonomiaGasolina = Console.ReadLine();
                            autonomiaGasolinaParsed = stringToFloat(autonomiaGasolina, 2);
                            if (autonomiaGasolinaParsed <= 0 || autonomiaAlcoolParsed <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Erro: Valores inválidos");
                                Console.Write("\n\nPressione enter para voltar ao menu\n");
                                Console.ReadLine();
                            }
                            veiculo.autonomiaGasolina = autonomiaGasolinaParsed;
                            veiculo.autonomiaEtanol = autonomiaAlcoolParsed;
                            configurado = true;
                            Console.Clear();
                            Console.Write("Menu Inicial > Editar Dados > Flex > Resultado :\n\n--- Dados configurados, agora você consegue realizar o cálculo do combustível com base na autonomia de seu veículo! ---\n\nPressione enter para voltar ao menu\n");
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Deseja encerrar o programa? 'S' / 'N'");
                            res = Console.ReadLine();
                            if (res == "s" || res == "S")
                            {
                                Console.WriteLine("Encerrando...");
                                return;
                            }
                            else if (res == "n" || res == "N")
                            {
                                Console.Write("\n\nOk.. pressione enter para voltar ao menu\n");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                Console.Write("\n\nVocê será redirecionado ao menu inicial, Pressione enter:\n");
                                Console.ReadLine();
                                break;


                            }
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção Inválida");
                            Console.Write("\n\nPressione enter para voltar ao menu\n");
                            Console.ReadLine();

                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Erro: Digite Apenas os números informados no menu.");
                    Console.Write("\n\nPressione enter para voltar ao menu\n");
                    Console.ReadLine();

                    continue;
                }


            } while (res != "s");



        }

        public class Carro
        {
            public float autonomiaGasolina { get; set; }
            public float autonomiaEtanol { get; set; }

            public Carro()
            {

            }
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
                return -1;
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
                return -1;
            }
        }
    }
}

//https://github.com/ZattadoGuaraci/Posto