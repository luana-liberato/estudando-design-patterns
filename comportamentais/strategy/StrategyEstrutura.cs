using System;

public class Strategy
{
    public static void Main()
    {
        string estrategiaEscolhida = "Estrat�gia B";
        Contexto contexto = new Contexto();
        Estrategia estrategia;

        if (estrategiaEscolhida == "Estrat�gia A") estrategia = new EstrategiaA();
        else estrategia = new EstrategiaB();

        contexto.setEstrategia(estrategia);
        contexto.executeEstrategia("Luana � linda");
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
            Console.WriteLine("Executando estrat�gia A para o dado {0}", dado);
        }
    }

    public class EstrategiaB : Estrategia
    {
        public void execucao(string dado)
        {
            Console.WriteLine("Executando estrat�gia B para o dado {0}", dado);
        }
    }

}