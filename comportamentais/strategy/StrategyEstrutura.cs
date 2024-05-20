using System;

public class Strategy
{
    public static void Main()
    {
        string estrategiaEscolhida = "Estratégia B";
        Contexto contexto = new Contexto();
        Estrategia estrategia;

        if (estrategiaEscolhida == "Estratégia A") estrategia = new EstrategiaA();
        else estrategia = new EstrategiaB();

        contexto.setEstrategia(estrategia);
        contexto.executeEstrategia("Luana é linda");
    }

    public class Contexto
    {
        public Estrategia estrategia;

        public void setEstrategia(Estrategia estrategia)
        {
            this.estrategia = estrategia;
        }

        public void executeEstrategia(String dado)
        {
            estrategia.execucao(dado);
        }
    }

    public interface Estrategia
    {
        public void execucao(String dado);
    }

    public class EstrategiaA : Estrategia
    {
        public void execucao(string dado)
        {
            Console.WriteLine("Executando estratégia A para o dado {0}", dado);
        }
    }

    public class EstrategiaB : Estrategia
    {
        public void execucao(string dado)
        {
            Console.WriteLine("Executando estratégia B para o dado {0}", dado);
        }
    }

}