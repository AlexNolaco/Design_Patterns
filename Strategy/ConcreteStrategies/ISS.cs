using Strategy.Entity;
using Strategy.Strategy;

namespace Strategy.ConcreteStrategies
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
