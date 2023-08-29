namespace OlaMundo.CalculoImpostos
{
    internal class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto OutroImposto) : base(OutroImposto) { }
        public ImpostoMuitoAlto() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20 + CalculaOutroImposto(orcamento);
        }
    }
}
