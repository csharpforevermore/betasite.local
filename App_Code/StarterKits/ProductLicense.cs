public sealed class ProductLicense
{
    ProductLicense()
    {
    }

    public static ProductLicense Instance
    {
        get
        {
            return Nested.instance;
        }
    }

    public bool IsValid(){
        return true;
    }

    class Nested
    {
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Nested()
        {
        }

        internal static readonly ProductLicense instance = new ProductLicense();
    }
}