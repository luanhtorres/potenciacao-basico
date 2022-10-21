namespace testeC_
{
    class Program
    {
        static void Main (string [] args)
        {
             double numero_base;
             double numero_potencia;
             double resultado_potenciacao;
        
            Console.WriteLine("Insira o número base: ");
            numero_base = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Insira o número da potencia: ");
            numero_potencia = Convert.ToInt32(Console.ReadLine());
            
            resultado_potenciacao = Math.Pow(numero_base, numero_potencia);
            
            Console.WriteLine("O resultado de " + numero_base + " elevado a " + numero_potencia +  " é: " + resultado_potenciacao);
            
        }
    }
}