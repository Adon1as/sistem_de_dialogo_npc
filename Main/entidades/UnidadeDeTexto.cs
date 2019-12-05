
using System;
public class UnidadeDeTexto{
    private string conteudo;
   
    //Lista de verificadores que iram perminir ou negar que o conteudo apareça
    private List<Controlador> controladoresDeEntrada = new List<bool>();

    //Lista de controladores que sofrem alteracao por passarem por essa unidade de texto
    private List<Controlador> controladoresAAtualizar = new List<bool>();
    
    //Lista IDs de outras UnidadeDeTexto que devem partir da atual
    //Pergutas passam para respostas que passam outras perguntas
    private List<int> filhas = new List<int>();
    
    //Se e uma pergunta ou respota
    public string TIPO; 


    public UnidadeDeTexto(string conteudo, List<Controlador> controladoresDeEntrada,List<Controlador> controladoresAAtualizar,  List<int> filhas, string tipo){
        this.conteudo = conteudo;
        this.controladoresDeEntrada = controladoresDeEntrada;  
        this.controladoresAAtualizar = controladoresAAtualizar;
        this.filhas = filhas;
        this.TIPO = tipo;
    }
}