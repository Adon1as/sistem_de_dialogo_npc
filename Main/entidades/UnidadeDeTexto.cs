
using System;
public class UnidadeDeTexto{
    private string conteudo;
    private List<Controlador> controladoresDeEntrada = new List<bool>();
    private List<Controlador> controladoresAAtualizar = new List<bool>();
    private List<int> filhas = new List<int>();
    public string TIPO; 


    public UnidadeDeTexto(string conteudo, List<Controlador> controladoresDeEntrada,List<Controlador> controladoresAAtualizar,  List<int> filhas, string tipo){
        this.conteudo = conteudo;
        this.controladoresDeEntrada = controladoresDeEntrada;  
        this.controladoresAAtualizar = controladoresAAtualizar;
        this.filhas = filhas;
        this.TIPO = tipo;
    }
}