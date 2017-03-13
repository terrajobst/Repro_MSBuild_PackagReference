using Newtonsoft.Json.Linq;

namespace ClassLibrary
{
    public class Class1
    {
        public override string ToString()
        {
            return Create().ToString();
        }

        public static JToken Create()
        {
            return JToken.Parse("123");
        }
    }
}
