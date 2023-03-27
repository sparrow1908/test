using Newtonsoft.Json.Linq;

namespace Dt.EsApi
{
    public static class JsonComparer
    {
        public static bool IsParsedAndEquals(string left, string right)
        {
            if (left is null && right is null)
            {
                return true;
            }

            if (left is null || right is null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(left) && string.IsNullOrEmpty(right))
            {
                return true;
            }

            if (string.IsNullOrEmpty(left) && !string.IsNullOrEmpty(right) || string.IsNullOrEmpty(right) && !string.IsNullOrEmpty(left))
            {
                return false;
            }

            return JToken.DeepEquals(JObject.Parse(left), JObject.Parse(right));
        }
    }
}
