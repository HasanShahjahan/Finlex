using System;

namespace Finlex.Common
{
    public static class UriExtensions
    {
        private static Uri AddQueryParams(this Uri url, (string, string) param1 = default, (string, string) param2 = default, (string, string) param3 = default)
        {
            var queryParams = "";
            var firstSeperator = url.Query.Length != 0 ? "&" : "?";

            if (param1 != default) queryParams = string.Concat(firstSeperator, param1.Item1, "=", param1.Item2);
            if (param2 != default) queryParams = string.Concat(queryParams, "&", param2.Item1, "=", param2.Item2);
            if (param3 != default) queryParams = string.Concat(queryParams, "&", param3.Item1, "=", param3.Item2);

            return new Uri(string.Concat(url, queryParams));
        }
    }
}
