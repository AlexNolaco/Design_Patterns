//interface STRATEGY VEJA DIAGRAMA
using Strategy.Entity;

namespace Strategy.Strategy
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}