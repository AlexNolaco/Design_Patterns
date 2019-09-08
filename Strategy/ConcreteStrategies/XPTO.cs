using Strategy.Entity;
using Strategy.Strategy;

namespace Strategy.ConcreteStrategies
{
    public class XPTO : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.60;
        }
    }
}
