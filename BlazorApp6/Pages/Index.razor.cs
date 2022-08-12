namespace BlazorApp6.Pages
{
    public partial class Index
    {
        public string MyProperty { get; set; }
        public void Click(string type)
        {
            MyProperty = $"{type} clicked";
        }
    }
}
