namespace Exceptions;

public class TrabalhandoComExcecoes
{
  public void AulaGerandoException()
  {
    while (true)
    {
      Console.Write("Deseja dividir 500 por qual número? ");
      var numero = Console.ReadLine();
      var resultado = 500 / int.Parse(numero); // Se o usuário digitar 0 irá gerar uma exception e a aplicação para
      Console.WriteLine("Resultado da divisão: " + resultado);
    }
  }

  public void AulaTratandoException()
  {
    while (true)
    {
      try
      {
        Console.Write("Deseja dividir 500 por qual número? ");
        var numero = Console.ReadLine();
        var resultado = 500 / int.Parse(numero); // Se o usuário digitar 0 irá gerar uma exception que será tratada pelo try catch e a aplicação continua rodando
        Console.WriteLine("Resultado da divisão: " + resultado);
      }
      catch (DivideByZeroException exception) // Tratamento de exceções customizadas
      {
        Console.WriteLine("O valor não pode ser dividido por zero.");
        Console.WriteLine("Mensagem do erro: " + exception.Message);
        Console.WriteLine("StackTrace do erro: " + exception.StackTrace);
      }
      catch (Exception exception) // Tratamento de exceções genéricas
      {
        Console.WriteLine("Ocorreu um erro");
        Console.WriteLine("Mensagem do erro: " + exception.Message);
        Console.WriteLine("StackTrace do erro: " + exception.StackTrace);
      }
    }
  }
}