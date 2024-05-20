using System;

public class ClasseCliente {

    public static ClasseCriadora criacao;

    public static void solicitacaoDeCriacao(){
        string solicitacao = "Produto B";

        if (solicitacao == "Produto A") criacao = new CriadorProdutoA();
        else criacao = new CriadorProdutoB();
    }

    public static void Main() {
        solicitacaoDeCriacao();
        criacao.usarProduto();
        Console.ReadLine();
    }

}

public abstract class ClasseCriadora {
    public abstract Produto metodoFabrica();

    public void usarProduto() {
        Produto produto = metodoFabrica();

        produto.mensagem();
        produto.mensagemDois();
    }
}

public class CriadorProdutoA : ClasseCriadora {
    override public Produto metodoFabrica() {
        return new ProdutoA();
    }
}

public class CriadorProdutoB : ClasseCriadora {
    override public Produto metodoFabrica() {
        return new ProdutoB();
    }
}

public interface Produto {
    void mensagem();
    void mensagemDois();
}

public class ProdutoA : Produto {
    public void mensagem() {
        Console.WriteLine("Mensagem 1 do Produto A");
    }

    public void mensagemDois() {
        Console.WriteLine("Mensagem 2 do Produto A");
    }
}

public class ProdutoB : Produto {
    public void mensagem() {
        Console.WriteLine("Mensagem 1 do Produto B");
    }

    public void mensagemDois() {
        Console.WriteLine("Mensagem 2 do Produto B");
    }
}