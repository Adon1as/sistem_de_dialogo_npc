using System;
//Faz o controle do fluxo de textos
public class Conversa{
    private List<UnidadeDeTexto> unidadeDeTexto = new List<UnidadeDeTexto>();
    private Leitor leitor;
    private InterfaceJogador jogador;

    public string getTextoAtual(){}

    public List<string> getFilhasDisponiveis(){}

    public void passarTexto(int idFilha){}

    //Caso seja um NPC e possua uma unica filha disponivel
    public void passarTextoAuto(){}
}