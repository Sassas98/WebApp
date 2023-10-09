namespace WebApp {
    public class App {
        static async Task Main(string[] args) {
            string Url = "https://tassidicambio.bancaditalia.it/terzevalute-wf-web/rest/v1.0/currencies";
            try {
                HttpResponseMessage response = await new HttpClient().GetAsync(Url);
                if (response.IsSuccessStatusCode) 
                    Console.WriteLine(await response.Content.ReadAsStringAsync());
                else throw new Exception(response.StatusCode.ToString());
            } catch (Exception e) {
                Console.WriteLine("Errore nella richiesta HTTP: " + e.Message);
            }
        }
    }
}