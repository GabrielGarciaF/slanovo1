public class Pessoa {
    private int _idade;
    private String _nome;

    public int Idade {
        get { return this._idade; }
        set { this._idade = value; }
    }

    public String Nome {
        get { return this._nome;}
        set { this._nome = value; }
    }

    public double Altura {
        get;set;
    }
}