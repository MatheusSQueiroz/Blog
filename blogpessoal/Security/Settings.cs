namespace blogpessoal.Security
{
    public class Settings
    {
        private static string secret = "b09d7c1aebebbc243f67ddea2c8093dae69e93ce165f7a746f6a9ce6c9f13d3d";

        public static string Secret { get => secret; set => secret = value; }
    }
}
