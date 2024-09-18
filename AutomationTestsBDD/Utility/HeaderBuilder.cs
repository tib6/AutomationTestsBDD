namespace AutomationTestsBDD.Utility
{
    public static class HeaderBuilder
    {
        public static readonly Action<HttpRequestHeaders> XmlHeaders = headers =>
        {
            headers.Accept.Clear();
            headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
        };

        public static readonly Action<HttpRequestHeaders> JsonHeaders = headers =>
        {
            headers.Clear();
            headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        };
    }
}
