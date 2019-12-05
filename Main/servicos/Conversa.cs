using System.Collections;
using System.Collections.Generic;
//Faz o controle do fluxo de textos
public class Conversa{
    private List<UnidadeDeTexto> unidadeDeTexto = new List<UnidadeDeTexto>();
    private Leitor leitor;
    private InterfaceJogador jogador;

    public string getTextoAtual(){
		return null;
	}

    public List<string> getFilhasDisponiveis(){
		return null;
	}

    public void passarTexto(int idFilha){
		
	}

    //Caso seja um NPC e possua uma unica filha disponivel
    public void passarTextoAuto(){}
}