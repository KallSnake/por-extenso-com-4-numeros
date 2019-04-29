using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPorExtensoCom4Digitos
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Informe 4 números: ");

            string num = Console.ReadLine();

            string nomePorExtenso = "";


            // Limitando pouco mais o usuário
            if ((num.Length < 4) || (num.Length > 4))
            {

                Console.WriteLine();
                Console.WriteLine("Erro no processamento. Tente novamente!");

            }
            else
            {


                string m = (num.Substring(0, 1));
                string c = (num.Substring(1, 1));
                string d = (num.Substring(2, 1));
                string u = (num.Substring(3, 1));

                string dez = (num.Substring(2, 2));

                // Console.WriteLine("Duas ultimas casas: " + dez);


                /*
                Console.WriteLine("Milhar: " + m);
                Console.WriteLine("Centena: " + c);
                Console.WriteLine("Dezena: " + d);
                Console.WriteLine("Unidade: " + u);
                */
                


                // Nome por Extenso na casa de MILHAR
                switch (m)
                {

                    case "1":
                        nomePorExtenso += "Mil";
                        break;

                    case "2":
                        nomePorExtenso += "Dois mil";
                        break;

                    case "3":
                        nomePorExtenso += "Três mil";
                        break;

                    case "4":
                        nomePorExtenso += "Quatro mil";
                        break;

                    case "5":
                        nomePorExtenso += "Cinco mil";
                        break;

                    case "6":
                        nomePorExtenso += "Seis mil";
                        break;

                    case "7":
                        nomePorExtenso += "Sete mil";
                        break;

                    case "8":
                        nomePorExtenso += "Oito mil";
                        break;

                    case "9":
                        nomePorExtenso += "Nove mil";
                        break;

                    case "0":
                        nomePorExtenso += "m";
                        break;
                    default:
                        break;

                }


                // System.out.println("Voçê informou: " + nomePorExtenso);



                // Nome por Extenso na casa da CENTENA
                switch (c)
                {

                    case "1":
                        nomePorExtenso += " e Cem";
                        break;

                    case "2":
                        nomePorExtenso += " e Duzentos";
                        break;

                    case "3":
                        nomePorExtenso += " e Trezentos";
                        break;

                    case "4":
                        nomePorExtenso += " e Quatrocentos";
                        break;

                    case "5":
                        nomePorExtenso += " e Quinhentos";
                        break;

                    case "6":
                        nomePorExtenso += " e Seiscentos";
                        break;

                    case "7":
                        nomePorExtenso += " e Setecentos";
                        break;

                    case "8":
                        nomePorExtenso += " e Oitocentos";
                        break;

                    case "9":
                        nomePorExtenso += " e Novecentos";
                        break;

                    case "0":
                        nomePorExtenso += "";
                        break;
                    default:
                        break;

                }


                // System.out.println("Voçê informou: " + nomePorExtenso);



                // Nome por Extenso na casa da DEZENA
                switch (d)
                {

                    case "2":
                        nomePorExtenso += " e Vinte";
                        break;

                    case "3":
                        nomePorExtenso += " e Trinta";
                        break;

                    case "4":
                        nomePorExtenso += " e Quarenta";
                        break;

                    case "5":
                        nomePorExtenso += " e Ciquenta";
                        break;

                    case "6":
                        nomePorExtenso += " e Sessenta";
                        break;

                    case "7":
                        nomePorExtenso += " e Setenta";
                        break;

                    case "8":
                        nomePorExtenso += " e Oitenta";
                        break;

                    case "9":
                        nomePorExtenso += " e Noventa";
                        break;

                    case "0":
                        nomePorExtenso += "";
                        break;
                    default:
                        break;

                }


                // System.out.println("Voçê informou: " + nomePorExtenso);




                // Nome por Extenso nas 2 (duas) ultimas casas (10 até 19)
                switch (dez)
                {


                    case "10":
                        nomePorExtenso += " e Dez";
                        break;

                    case "11":
                        nomePorExtenso += " e Onze";
                        break;

                    case "12":
                        nomePorExtenso += " e Doze";
                        break;

                    case "13":
                        nomePorExtenso += " e Treze";
                        break;

                    case "14":
                        nomePorExtenso += " e Quatorze";
                        break;

                    case "15":
                        nomePorExtenso += " e Quinze";
                        break;

                    case "16":
                        nomePorExtenso += " e Dezesseis";
                        break;

                    case "17":
                        nomePorExtenso += " e Dezessete";
                        break;

                    case "18":
                        nomePorExtenso += " e Dezoito";
                        break;

                    case "19":
                        nomePorExtenso += " e Dezenove";
                        break;

                    case "00":
                        nomePorExtenso += "";
                        break;

                    default:
                        break;

                }


                // System.out.println("Voçê informou: " + nomePorExtenso);




                // Nome por Extenso na casa da UNIDADE
                if ((dez != "10") && (dez != "11") && (dez != "12") && (dez != "13") && (dez != "14") && (dez != "15") && (dez != "16") && (dez != "17") && (dez != "18") && (dez != "19") && (d == "1" || d.Equals("2") || d.Equals("3") || d.Equals("4") || d.Equals("5") || d.Equals("6") || d.Equals("7") || d.Equals("8") || d.Equals("9")))
                {

                    switch (u)
                    {

                        case "1":
                            nomePorExtenso += " e Um";
                            break;

                        case "2":
                            nomePorExtenso += " e Dois";
                            break;

                        case "3":
                            nomePorExtenso += " e Três";
                            break;

                        case "4":
                            nomePorExtenso += " e Quatro";
                            break;

                        case "5":
                            nomePorExtenso += " e Cinco";
                            break;

                        case "6":
                            nomePorExtenso += " e Seis";
                            break;

                        case "7":
                            nomePorExtenso += " e Sete";
                            break;

                        case "8":
                            nomePorExtenso += " e Oito";
                            break;

                        case "9":
                            nomePorExtenso += " e Nove";
                            break;

                        default:
                            break;

                    }

                }



                string replaceNomePorExtenso = "";





                if (m.Equals("0") && c.Equals("0") && d.Equals("0") && u.Equals("0"))
                {

                    Console.WriteLine();
                    Console.WriteLine("Voçê informou 4 (quatro) sequência de 0 (zero). Favor tente novamente!");

                }
                else if (m.Equals("0"))
                {

                    string verificarM = nomePorExtenso.Substring(0, 3);

                    // Console.WriteLine();("...: " + verificarM);

                    replaceNomePorExtenso = nomePorExtenso.Replace(verificarM, "");

                    if (replaceNomePorExtenso != "" && c != "1")
                    {

                        Console.WriteLine();
                        Console.WriteLine("Voçê informou: " + replaceNomePorExtenso.Replace("Cem", "Cento"));

                    }

                }
                else if (c != "1")
                {

                    Console.WriteLine();
                    Console.WriteLine("Voçê informou: " + nomePorExtenso.Replace("Cem", "Cento"));

                }
                else
                {

                    Console.WriteLine();
                    Console.WriteLine("Voçê informou: " + nomePorExtenso);

                }



            } // Fim Algoritmo


            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
