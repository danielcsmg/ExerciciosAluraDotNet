using static OlaMundo.RespostaFormulario;

namespace OlaMundo;

public static class RespostaFormulario
{
    public enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }

    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }

    public interface IResposta
    {
        public IResposta Proximo { get; set; }

        public string ResponderConta(Requisicao requisicao);
    }

    public class RespostaXML : IResposta
    {
        public IResposta Proximo { get; set; }

        public RespostaXML(IResposta proximo)
        {
            Proximo = proximo;
        }

        public string ResponderConta(Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.XML)
            {
                return "conta <>";
            }

            return Proximo.ResponderConta(requisicao);
        }
    }

    public class RespostaCVS : IResposta
    {
        public IResposta Proximo { get; set; }

        public RespostaCVS(IResposta proximo)
        {
            Proximo = proximo;
        }

        public string ResponderConta(Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                return "conta ;";
            }

            return Proximo.ResponderConta(requisicao);
        }
    }

    public class RespostaPorcento : IResposta
    {
        public IResposta Proximo { get; set; }

        public RespostaPorcento(IResposta proximo)
        {
            Proximo = proximo;
        }

        public string ResponderConta(Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                return "conta %";
            }

            return Proximo.ResponderConta(requisicao);
        }
    }

    public class RespostaErro : IResposta
    {
        public IResposta Proximo { get; set; }

        public string ResponderConta(Requisicao requisicao)
        {
            return "Formato não identificado";
        }
    }


    public class PedidoDeConta
    {
        public string EnviarContaFormatada(Requisicao requisicao)
        {
            IResposta contaErro = new RespostaErro();
            IResposta contaCVS = new RespostaCVS(contaErro);
            IResposta contaPorc = new RespostaPorcento(contaCVS);
            IResposta contaXml = new RespostaXML(contaPorc);

            return contaXml.ResponderConta(requisicao);
        }
    }

}
    public static class Calc
    {
        public static void FormatarContas()
        {
            var pedidoConta = new PedidoDeConta();
            var requisicao = new Requisicao(Formato.PORCENTO);

            var contaFormatada = pedidoConta.EnviarContaFormatada(requisicao);
            Console.WriteLine(contaFormatada);
        }
    }
