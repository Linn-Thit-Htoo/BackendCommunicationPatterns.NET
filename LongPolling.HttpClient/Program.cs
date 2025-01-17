public class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            HttpClient client = new()
            {
                BaseAddress = new Uri("http://localhost:5005")
            };

            Console.WriteLine("Calling API...");
            HttpResponseMessage response = await client.GetAsync("/efficient");
            response.EnsureSuccessStatusCode();
            string jsonStr = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"Response: {jsonStr}");
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}