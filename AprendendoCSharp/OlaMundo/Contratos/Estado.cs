using System.Diagnostics.Contracts;

namespace OlaMundo.Contratos;

public class Estado
{
    public Contrato Contrato { get; private set; }

    public Estado(Contrato contrato)
    {
        this.Contrato = contrato;
    }
}
