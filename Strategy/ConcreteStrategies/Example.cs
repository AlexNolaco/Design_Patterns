﻿using Strategy.Entity;
using Strategy.Strategy;

namespace Strategy.ConcreteStrategies
{
    public class Example : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.60;
        }
    }
}
