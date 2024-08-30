using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
      
        static void Start(int time){
            
        int corendoTempo = 0;

        while (corendoTempo != time)
        {
            Console.Clear();
            corendoTempo++;
            Console.WriteLine(corendoTempo);
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Cronometro finalizado...... voltando para o menu");
        Thread.Sleep(2500);
        Menu();

        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0s = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1 ,1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplier = 1;
            if (type == 'm'){
                multiplier = 60;
            }
            if (time == 0){
                System.Environment.Exit(0);
            }
            Start(time * multiplier);
            Menu();

        }
}