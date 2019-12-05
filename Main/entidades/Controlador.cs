//Permiçao que disponibiliza ou empede a chamadas de textos
public class Controlador{
    private bool valor;
    private string nome;
    private int id;

    public int Id { get => id; set => id = value; }
    public string Nome { get => nome; set => nome = value; }
    public bool Valor { get => valor; set => valor = value; }
}