namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
      Operacoes op = new Operacoes();
      op.Menu();
      op.Somar();
      op.Subtrair();
      op.Multiplicar();
      op.Dividir();

      
    }
}
