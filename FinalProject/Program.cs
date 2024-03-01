using System.Numerics;
using System.Runtime.CompilerServices;

namespace FinalProject
{   // colocar opção de voltar
    // tratar os dados no case 2, e no preço dos combustiveis (lembrar de validar valores zerados / nulos)
    // opção de voltar ao menu anterior
    // colocar default nos outros switch cases tambem
    // verificar se quer 
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool configurado = false;
            Carro veiculo = new Carro();

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

                                    if (configurado)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Qual o preço do Etanol?: ");
                                        string precoEtanol = Console.ReadLine();
                                        Console.WriteLine("Qual o preço da Gasolina?: ");
                                        string precoGasolina = Console.ReadLine();

                                        float precoGasolinaParsed = stringToFloat(precoGasolina, 2);
                                        float precoEtanolParsed = stringToFloat(precoEtanol, 2);

                                        float percentual = veiculo.autonomiaEtanol / veiculo.autonomiaGasolina;
                                        if((percentual * precoGasolinaParsed) > precoEtanolParsed)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"Compensa Etanol");
                                            //etanol menor
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"compensa Gasolina");
                                            //gasolina
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Qual o preço do Etanol?: ");
                                        string precoEtanol = Console.ReadLine();
                                        Console.WriteLine("Qual o preço da Gasolina?: ");
                                        string precoGasolina = Console.ReadLine();

                                        float precoGasolinaParsed = stringToFloat(precoGasolina, 2);
                                        float precoEtanolParsed = stringToFloat(precoEtanol, 2);

                                        float percentual = ((float)(0.7 * precoGasolinaParsed));
                                        if (percentual > precoEtanolParsed)
                                        {
                                            //compensa etanol 
                                            Console.Clear();
                                            Console.WriteLine($"Compensa Etanol");

                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"Compensa Gasolina");

                                        }


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
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Selecione abaixo uma das opções que correspondem ao tipo de combustível do seu veículo\n1 - Etanol\n2 - Gasolina\n3 - Flex:");
                            string opt = Console.ReadLine();
                            int result2 = stringToInteger(opt);

                            switch (result2)
                            {
                                case 1:

                                    Console.WriteLine("Digite a autonomia do veículo no Álcool (em km/L)");
                                    string autonomiaAlcool1 = Console.ReadLine();
                                    autonomiaAlcoolParsed = stringToFloat(autonomiaAlcool1, 2);
                                    veiculo.autonomiaEtanol = autonomiaAlcoolParsed;
                                    Console.Clear();

                                    Console.Write("Dados configurados\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Digite a autonomia do seu veículo na Gasolina (em km/L)");
                                    string autonomiaGasolina2 = Console.ReadLine();
                                    autonomiaGasolinaParsed = stringToFloat(autonomiaGasolina2, 2);
                                    Console.WriteLine(autonomiaGasolinaParsed);
                                    veiculo.autonomiaGasolina = autonomiaGasolinaParsed;
                                    Console.Clear();

                                    Console.Write("Dados configurados\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();

                                    break;
                                case 3:
                                    Console.Clear();
                                    string autonomiaAlcool;
                                    Console.WriteLine("Digite a autonomia do veículo no Álcool");
                                    autonomiaAlcool = Console.ReadLine();
                                    autonomiaAlcoolParsed = stringToFloat(autonomiaAlcool, 2);
                                    Console.WriteLine("Digite a autonomia do seu veículo na Gasolina");
                                    string autonomiaGasolina;
                                    autonomiaGasolina = Console.ReadLine();
                                    autonomiaGasolinaParsed = stringToFloat(autonomiaGasolina, 2);
                                    veiculo.autonomiaGasolina = autonomiaGasolinaParsed;
                                    veiculo.autonomiaEtanol = autonomiaAlcoolParsed;
                                    configurado = true;
                                    Console.Clear();
                                    Console.Write("Dados configurados\nPressione enter para voltar ao menu\n");
                                    Console.ReadLine();

                                    break;

                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Deseja encerrar o programa? S/N");
                            string res = Console.ReadLine();
                            if(res == "s"){
                                return;
                            } else if( res == "n")
                            {
                                Console.Write("\n\nPressione enter para voltar ao menu\n");
                                Console.ReadLine();

                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                break;


                            }
                            //colcoar a logica ai... e validar se é s ou n

                            break;
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
                    Console.WriteLine("Digite Apenas os números informados no menu."); // colocar um timer de uns 3s, e depois redirecionar para o início
                    Console.WriteLine("Opção Inválida");
                    Console.Write("\n\nPressione enter para voltar ao menu\n");
                    Console.ReadLine();

                    continue;
                }


            } while (number != 3);


         
        }

        public class Carro
        {
            public float autonomiaGasolina {get; set;}
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