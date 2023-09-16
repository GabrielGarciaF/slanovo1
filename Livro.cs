public class Livro {
    private static int _cont;
    private String _titulo;

    public String Titulo {
        get { return this._titulo; }
        set { this._titulo = value; }
    }

    public static int Contador {
        get { return _cont; }
        set {_cont = value; }
    }

    private Livro() {}

    public static Livro getLivro() {
        Livro.Contador++;
        return new Livro();
    }
}