using OrientadoAObjetoVeiculos.Factory;
using OrientadoAObjetoVeiculos.InterfaceFactory;
using OrientadoAObjetoVeiculos.Interfaces;
using OrientadoAObjetoVeiculos.Models;
using System;
using System.Threading;
                                   //Arquitetura do código:
namespace OrientadoAObjetoVeiculos //Herança, interface e factory! //O código está separado por etapas: funções, desligamento do veículo e abertura/fechamento de portas
{
    public class Program
    {
        /*----------------------------------------------------------*/
        private static readonly ICarroFactory _carrofactory;
        private static readonly IBarcoFactory _barcofactory;
        private static readonly IAviaoFactory _aviaofactory;
        private static readonly IMotorFactory _motorfactory;
        private static readonly IPortasFactory _portasfactory;
        private static readonly IRodasFactory _rodasfactory;
        private static readonly IBicicletaFactory _bicicletafactory;
        private static readonly ICanoaFactory _canoafactory ;
        static Program()
        {
            _carrofactory = new CarroFactory();
            _barcofactory = new BarcoFactory();
            _aviaofactory = new AviaoFactory();
            _motorfactory = new MotorFactory();
            _portasfactory = new PortasFactory();
            _rodasfactory = new RodasFactory();
            _bicicletafactory = new BicicletaFactory();
            _canoafactory = new CanoaFactory();
        }
        /*---------------------------------------------------------*/
        public static void Main(string[] args)
        {
            EscolherVeiculo();
        }
        public static void EscolherVeiculo()
        {
            bool isValido = true;

            while(isValido)
            {
                try
                {
                    Console.WriteLine("Escolha entre as seguintes opções: \n");
                    Console.WriteLine("\t 1 - Veículo motorizado" +
                                        "\t 2 - Veículo não motorizado \n");
                    int opc = int.Parse(Console.ReadLine());
                    isValido = opc > 0 && opc <= 2;
                    switch (opc)
                    {
                        case 1:
                            VeiculoMotorizado();
                            break;
                        case 2:
                            VeiculoNaoMotorizado();
                            break;
                    }
                }
                catch
                {
                    if (!isValido)
                    Console.WriteLine("Código inválido!");
                }
            }
           
        }
        public static void VeiculoMotorizado()
        {
            Console.WriteLine("\n Escolha o veículo: ");
            Console.WriteLine(@"
                        1- Carro
                        2- Barco
                        3- Avião
                        4- Sair"+"\n");
            int opc = int.Parse(Console.ReadLine());

            ICarro carro = null;
            IBarco barco = null;
            IAviao aviao = null;

            switch (opc)
            {
                case 1:
                    Console.WriteLine("\n Escolha o carro:" + "\n");
                    Console.WriteLine(@"
                        1- HB20
                        2- FordKa
                        3- Sair"+"\n");
                    int opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            carro = _carrofactory.BuildHB20(_motorfactory, _portasfactory, _rodasfactory);
                            break;
                        case 2:
                            carro = _carrofactory.BuildFordKa(_motorfactory, _portasfactory, _rodasfactory);
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Número inválido!");
                            break;
                    }
                    Console.WriteLine(carro.ToString(), carro.Portas.ToString(), carro.Rodas.ToString(), ((IVeiculoMotorizado)carro).Motor.ToString());

                    RetornaAbrirPortaCarro(carro);
                    RetornaCarroFuncoes(carro);
                    RetornaFecharPortaCarro(carro);

                    break;
                case 2:
                    Console.WriteLine("Escolha o barco: " + "\n");
                    Console.WriteLine(@"
                        1- Intermarine");
                    int opcao2 = int.Parse(Console.ReadLine());
                    switch (opcao2)
                    {
                        case 1:
                            barco = _barcofactory.BuildIntermarine(_motorfactory);
                            break;
                    }
                    Console.WriteLine(barco.ToString(), ((IVeiculoMotorizado)barco).Motor.ToString());

                    RetornaBarcoFuncoes(barco);

                    break;
                case 3:
                    Console.WriteLine("Escolha o avião: " + "\n");
                    Console.WriteLine($@"
                        1- Airbus A380");
                    int opcao3 = int.Parse(Console.ReadLine());
                    switch (opcao3)
                    {
                        case 1:
                            aviao = _aviaofactory.BuildA380(_motorfactory, _portasfactory, _rodasfactory);
                            break;
                    }
                    Console.WriteLine(aviao.ToString(), aviao.Portas.ToString(), aviao.Rodas.ToString(), ((IVeiculoMotorizado)aviao).Motor.ToString());

                    RetornaAbrirPortaAviao(aviao);
                    RetornaAviaoFuncoes(aviao);
                    RetornaFecharPortaAviao(aviao);

                    break;
            }
            
        }

        public static void VeiculoNaoMotorizado()
        {
            Console.WriteLine("Escolha o veículo: ");
            Console.WriteLine(@$"
                    1- Bicicleta
                    2- Canoa
                    3- Sair");
            int opc = int.Parse(Console.ReadLine());

            IBicicleta bicicleta = null;
            ICanoa canoa = null;

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Escolha a bicicleta:" + "\n");
                    Console.WriteLine($@"
                    1- Caloi");
                    int opcao4 = int.Parse(Console.ReadLine());
                    switch (opcao4)
                    {
                        case 1:
                            bicicleta = _bicicletafactory.BuildBicicleta(_rodasfactory);
                            break;
                    }
                    Console.WriteLine(bicicleta.ToString(), bicicleta.Rodas.ToString());

                    RetornaBicicletaFuncoes(bicicleta);

                    break;
                case 2:
                    Console.WriteLine("Escolha a canoa:" + "\n");
                    Console.WriteLine($@"
                    1- Canoa");
                    int opcao5 = int.Parse(Console.ReadLine());
                    switch (opcao5)
                    {
                        case 1:
                            canoa = _canoafactory.BuildCanoa();
                            break;
                    }
                    Console.WriteLine(canoa.ToString());

                    RetornaCanoaFuncoes(canoa);

                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        public static void RetornaCanoaFuncoes(ICanoa canoa)
        {
            Console.WriteLine("Use as setas do teclado para coordenar o veículo," + "\n" +
                                   "Seta cima = acelerar;" + "\n" +
                                   "Seta baixo = frear; " + "\n" +
                                   "Seta esquerda e direita = para os lados;" + "\n");

            Console.WriteLine("Vamos remar!");
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine();

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine(((IVeiculo)canoa).Andar());
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine(((IVeiculo)canoa).Frear());
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine(((IVeiculo)canoa).VirarEsquerda());
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine(((IVeiculo)canoa).VirarDireita());
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            Console.WriteLine("Você chegou ao seu destino!");
        }
        public static void RetornaBicicletaFuncoes(IBicicleta bicicleta)
        {
            Console.WriteLine("Use as setas do teclado para coordenar o veículo," + "\n" +
                                   "Seta cima = acelerar;" + "\n" +
                                   "Seta baixo = frear; " + "\n" +
                                   "Seta esquerda e direita = para os lados;" + "\n");

            Console.WriteLine("Vamos pedalar!");
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine();

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine(((IVeiculo)bicicleta).Andar());
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine(((IVeiculo)bicicleta).Frear());
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine(((IVeiculo)bicicleta).VirarEsquerda());
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine(((IVeiculo)bicicleta).VirarDireita());
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            Console.WriteLine("Você chegou ao seu destino!");
        }

        public static void RetornaCarroFuncoes(ICarro carro)
        {
            Thread.Sleep(1000);

            Console.WriteLine(Enuns.TipoStatusMotor.Desligado);
            Thread.Sleep(1000);
            Console.WriteLine("Parece que o sujeito está desligado, aperte G para ligar!");

            Console.WriteLine();

            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.G:
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    Console.WriteLine(carro.DarTranco());
                    Thread.Sleep(2000);
                    Console.WriteLine("Ta quase ligando, continua empurrando!");
                    Console.Beep(700, 100); Thread.Sleep(500); Console.Beep(700, 100); Thread.Sleep(400); Console.Beep(700, 100); Thread.Sleep(300); Console.Beep(700, 100); Thread.Sleep(200); Console.Beep(700, 100); Thread.Sleep(100); Console.Beep(700, 100); Thread.Sleep(100); Console.Beep(700, 100); Thread.Sleep(200); Console.Beep(700, 100); Thread.Sleep(300); Console.Beep(700, 100); Thread.Sleep(400); Console.Beep(700, 100); Thread.Sleep(500); Console.Beep(700, 100); Thread.Sleep(600); Console.Beep(700, 100); Thread.Sleep(700); Console.Beep(700, 100); Thread.Sleep(800); Console.Beep(700, 100); Thread.Sleep(900); Console.Beep(700, 100); Thread.Sleep(1000);
                    Thread.Sleep(1000);
                    Console.WriteLine("Uma hora tem que ligar!");
                    Thread.Sleep(2000);
                    break;
            }
            Console.WriteLine("Vamos tentar de novo, aperte G para dar ignição");

            Console.WriteLine();

            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.G:
                    Thread.Sleep(1000);

                    Console.WriteLine(Enuns.TipoStatusMotor.Ligado);
                    Console.Beep(700, 100); Thread.Sleep(500); Console.Beep(700, 100); Thread.Sleep(400); Console.Beep(700, 100); Thread.Sleep(300); Console.Beep(700, 100); Thread.Sleep(200); Console.Beep(700, 100); Thread.Sleep(100); Console.Beep(700, 100); Thread.Sleep(100); Console.Beep(700, 100); Console.Beep(700, 100); Console.Beep(700, 100); Console.Beep(700, 100); Console.Beep(700, 100); Console.Beep(700, 100); Console.Beep(700, 100); Console.Beep(700, 100); Console.Beep(700, 100); Console.Beep(700, 100); Console.Beep(700, 100); Console.Beep(700, 100);
                    Thread.Sleep(2000);
                    Console.WriteLine();

                    break;
            }

            Console.WriteLine("Ligamos o sujeito, pé na estrada!");
            Console.WriteLine();

            Console.WriteLine(@"Use as setas do teclado para coordenar o veículo:" + "\n" +
                                "Aperte ENTER para sair do loop!" + "\n" +
                                "Seta cima = acelerar;" + "\n" +
                                "Seta baixo = frear; " + "\n" +
                                "Seta esquerda e direita = para os lados;" + "\n" +
                                "Use E para abastecer!" + "\n");

            Console.WriteLine("O meio de transporte encontra-se parado! o velocimetro está em: " + ((IVeiculoMotorizado)carro).VelocidadeAtual + "Km/h");

            do
            {
                Console.WriteLine();

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine(((IVeiculoMotorizado)carro).Andar());
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine(((IVeiculoMotorizado)carro).Frear());
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine(((IVeiculoMotorizado)carro).VirarEsquerda());
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine(((IVeiculoMotorizado)carro).VirarDireita());
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine(((IVeiculoMotorizado)carro).SetAbastecer());
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            Console.WriteLine("Você chegou ao show de drift, som na caixa!");
            Thread.Sleep(2000);
            Console.Beep(700, 200); Thread.Sleep(800); Console.Beep(700, 200); Thread.Sleep(800); Console.Beep(700, 200); Thread.Sleep(800); Console.WriteLine("mudar2º"); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(150); Console.Beep(700, 200); Console.WriteLine("mudar3º"); Console.Beep(700, 150); Thread.Sleep(900); Console.Beep(700, 150); Thread.Sleep(900); Console.WriteLine("mudar4º"); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(150); Console.Beep(700, 200); Console.WriteLine("mudar5º"); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150); Console.WriteLine("saindo do beep longo"); Console.Beep(700, 300); Thread.Sleep(100); Console.Beep(700, 300); Thread.Sleep(100); Console.WriteLine("mudarº7"); Console.Beep(700, 200); Thread.Sleep(150); Console.Beep(700, 200); Thread.Sleep(150); Console.Beep(700, 200); Thread.Sleep(150); Console.Beep(700, 200); Console.WriteLine("mudar faixa rapida"); Console.Beep(700, 200); Thread.Sleep(50); Console.Beep(700, 200); Thread.Sleep(50); Console.Beep(700, 200); Console.Beep(700, 200); Console.Beep(700, 200); Console.WriteLine("mudar5º"); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150);
            Console.Beep(700, 200); Thread.Sleep(800); Console.Beep(700, 200); Thread.Sleep(800); Console.Beep(700, 200); Thread.Sleep(800); Console.WriteLine("mudar2º"); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(150); Console.Beep(700, 200); Console.WriteLine("mudar3º"); Console.Beep(700, 150); Thread.Sleep(900); Console.Beep(700, 150); Thread.Sleep(900); Console.WriteLine("mudar4º"); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(100); Console.Beep(700, 200); Thread.Sleep(150); Console.Beep(700, 200); Console.WriteLine("mudar5º"); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150); Console.WriteLine("saindo do beep longo"); Console.Beep(700, 300); Thread.Sleep(100); Console.Beep(700, 300); Thread.Sleep(100); Console.WriteLine("mudarº7"); Console.Beep(700, 200); Thread.Sleep(150); Console.Beep(700, 200); Thread.Sleep(150); Console.Beep(700, 200); Thread.Sleep(150); Console.Beep(700, 200); Console.WriteLine("mudar faixa rapida"); Console.Beep(700, 200); Thread.Sleep(50); Console.Beep(700, 200); Thread.Sleep(50); Console.Beep(700, 200); Console.Beep(700, 200); Console.Beep(700, 200); Console.WriteLine("mudar5º"); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150); Console.Beep(700, 300); Thread.Sleep(150);
            Console.WriteLine();

            Console.WriteLine("Desligar o veículo? aperte G!");
            DesligarVeículo();
        }

        
        public static void RetornaBarcoFuncoes(IBarco barco)
        {
            Thread.Sleep(1000);

            Console.WriteLine(Enuns.TipoStatusMotor.Desligado);
            Thread.Sleep(1000);
            Console.WriteLine("Parece que o sujeito está desligado, aperte G para ligar!");

            Console.WriteLine();
            
            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.G:
                    Thread.Sleep(1000);

                    Console.WriteLine(Enuns.TipoStatusMotor.Ligado);
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    break;
            }

            Console.WriteLine("Ligamos o sujeito, pé na estrada!");
            Console.WriteLine();

            Console.WriteLine("Use as setas do teclado para coordenar o veículo," + "\n" +
                                "Seta cima = acelerar;" + "\n" +
                                "Seta baixo = frear; " + "\n" +
                                "Seta esquerda e direita = para os lados;" + "\n" +
                                "Use E para abastecer!" + "\n");

            Console.WriteLine("O meio de transporte encontra-se parado! o velocimetro está em: " + ((IVeiculoMotorizado)barco).VelocidadeAtual + "Km/h");

            do
            {
                Console.WriteLine();

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine(((IVeiculoMotorizado)barco).Andar());
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine(((IVeiculoMotorizado)barco).Frear());
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine(((IVeiculoMotorizado)barco).VirarEsquerda());
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine(((IVeiculoMotorizado)barco).VirarDireita());
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine(((IVeiculoMotorizado)barco).SetAbastecer());
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            Console.WriteLine("Você chegou ao seu destino!");
            Console.WriteLine();

            Console.WriteLine("Desligar o veículo? aperte G!");
            DesligarVeículo();
        }

        public static void RetornaAviaoFuncoes(IAviao aviao)
        {
            Thread.Sleep(1000);

            Console.WriteLine(Enuns.TipoStatusMotor.Desligado);
            Thread.Sleep(1000);
            Console.WriteLine("Parece que o sujeito está desligado, aperte G para ligar!");

            Console.WriteLine();

            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.G:
                    Thread.Sleep(1000);

                    Console.WriteLine(Enuns.TipoStatusMotor.Ligado);
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    break;
            }

            Console.WriteLine("Ligamos o sujeito, pé na estrada!");
            Console.WriteLine();

            Console.WriteLine("Use as setas do teclado para coordenar o veículo," + "\n" +
                                "Seta cima = acelerar;" + "\n" +
                                "Seta baixo = frear; " + "\n" +
                                "Seta esquerda e direita = para os lados;" + "\n" +
                                "Use E para abastecer!" + "\n");

            Console.WriteLine("O meio de transporte encontra-se parado! o velocimetro está em: " + ((IVeiculoMotorizado)aviao).VelocidadeAtual + "Km/h"); //O cast muda o endereço na memória

            do
            {
                Console.WriteLine();

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine(((IVeiculoMotorizado)aviao).Andar());
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine(aviao.Pousar());
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine(((IVeiculoMotorizado)aviao).VirarEsquerda());
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine(((IVeiculoMotorizado)aviao).VirarDireita());
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine(((IVeiculoMotorizado)aviao).SetAbastecer());
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            Console.WriteLine("Você chegou ao seu destino!");
            Console.WriteLine();

            Console.WriteLine("Desligar o veículo? aperte G!");
            DesligarVeículo();
        }

        public static void RetornaAbrirPortaCarro(ICarro carro)
        {
           

            Console.WriteLine();
            Console.WriteLine("Abrir a porta do veículo? aperte F!");
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine();

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.F:
                        Thread.Sleep(1000);

                        Console.WriteLine(carro.Portas.Abrir());
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);
        }
        public static void RetornaAbrirPortaAviao(IAviao aviao)
        {
            Console.WriteLine();
            Console.WriteLine("Abrir a porta do veículo? aperte F!");
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine();

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.F:
                        Thread.Sleep(1000);

                        Console.WriteLine(aviao.Portas.Abrir());
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);
        }

        public static void RetornaFecharPortaCarro(ICarro carro)
        {
            Console.WriteLine();
            Console.WriteLine("Fechar a porta do veículo? aperte F!");
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine();

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.F:
                        Thread.Sleep(1000);

                        Console.WriteLine(carro.Portas.Fechar());
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);
            Environment.Exit(0);
        }
        public static void RetornaFecharPortaAviao(IAviao aviao)
        {
            Console.WriteLine();
            Console.WriteLine("Fechar a porta do veículo? aperte F!");
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine();

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.F:
                        Thread.Sleep(1000);

                        Console.WriteLine(aviao.Portas.Fechar());
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);
            Environment.Exit(0);
        }
        public static void DesligarVeículo()
        {
            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.G:
                    Thread.Sleep(1000);

                    Console.WriteLine(Enuns.TipoStatusMotor.Desligado);
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    break;
            }
        }
    }
}