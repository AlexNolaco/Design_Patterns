using Strategy.Entity;
using Strategy.Strategy;
using System;

namespace Strategy.Context
{
    public class CalculadorDeImpostos
    {
        IImposto imposto;
        //no construtor eu carrego quem vai ser o imposto que vou chamar
        public CalculadorDeImpostos(IImposto _imposto)
        {
            this.imposto = _imposto;
        }

        public void RealizaCalculo(Orcamento orcamento)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
