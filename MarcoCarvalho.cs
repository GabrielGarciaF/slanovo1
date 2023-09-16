public class MarcoCarvalho {
    public static void fibonacci() {
        // Define um vetor de 10 valores inteiros
        int[] resultado = new int[10];
        // Define o valor dos 2 primeiros ítens do vetor
        resultado[0] = 1;
        resultado[1] = 1;

        // Calcular os demais ítens da sequencia
        for(int pos = 2;pos < 10;pos++) {
            resultado[pos] = resultado[pos - 1] + resultado[pos - 2];
        }

        // Exibindo o conteúdo do vetor 'resultado'
        foreach(int item in resultado) {
            Console.WriteLine(item);
        }
    }

    public static int[] Sequencia {
        get {
            // Define um vetor de 10 valores inteiros
            int[] resultado = new int[10];
            // Define o valor dos 2 primeiros ítens do vetor
            resultado[0] = 1;
            resultado[1] = 1;

            // Calcular os demais ítens da sequencia
            for(int pos = 2;pos < 10;pos++) {
                resultado[pos] = resultado[pos - 1] + resultado[pos - 2];
            }
            return resultado;
        }
    }
}