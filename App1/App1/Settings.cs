namespace App1
{
    public class Settings
    {
        // Generally I would not store the API key in plain text, but this is a quick and dirty app.
        public static string TaxJarApiBase => "https://api.taxjar.com/v2/";
        public static string TaxJarKey => "5da2f821eee4035db4771edab942a4cc";
    }
}