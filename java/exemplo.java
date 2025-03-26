import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class ApiRequestExample {
    public static void main(String[] args) {
        try {
            // URL da API
            String apiUrl = "https://api.sintegrapi.com.br/consultas/sintegra/15436940000103";
            // Chave da API
            String apiKey = "SUA_API_KEY";  // Substitua pela sua chave da API

            // Criando a URL
            URL url = new URL(apiUrl);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();

            // Definindo o método de requisição como GET
            connection.setRequestMethod("GET");

            // Adicionando o cabeçalho da chave da API
            connection.setRequestProperty("x-api-key", apiKey);

            // Obtendo o código de resposta HTTP
            int status = connection.getResponseCode();
            System.out.println("HTTP Status Code: " + status);

            // Lendo a resposta da API
            BufferedReader in = new BufferedReader(new InputStreamReader(connection.getInputStream()));
            String inputLine;
            StringBuilder response = new StringBuilder();

            while ((inputLine = in.readLine()) != null) {
                response.append(inputLine);
            }
            in.close();

            // Exibindo a resposta da API
            System.out.println("Resposta da API:");
            System.out.println(response.toString());

        } catch (Exception e) {
            System.out.println("Erro: " + e.getMessage());
        }
    }
}
