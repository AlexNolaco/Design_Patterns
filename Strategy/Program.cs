using Strategy.ConcreteStrategies;
using Strategy.Context;
using Strategy.Entity;
using Strategy.Strategy;

//CONTEXT
namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            /*finge que aqui é uma injeção de dependencia por construtor*/
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto xpto = new XPTO();
            IImposto example = new Example();
            /*fim da injeção*/

            Orcamento orcamento = new Orcamento(500.0);
            CalculadorDeImpostos context;

            context = new CalculadorDeImpostos(iss);
            context.RealizaCalculo(orcamento);

            context = new CalculadorDeImpostos(icms);
            context.RealizaCalculo(orcamento);

            context = new CalculadorDeImpostos(xpto);
            context.RealizaCalculo(orcamento);

            context = new CalculadorDeImpostos(example);
            context.RealizaCalculo(orcamento);
        }
    }
}
