using Newtonsoft.Json.Linq;

namespace ClassLibrary
{
    public class Class1
    {
        public override string ToString()
        {
            return JToken.Parse("123").ToString();
        }
    }
}
