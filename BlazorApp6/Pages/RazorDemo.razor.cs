using Microsoft.AspNetCore.Authorization;

namespace BlazorApp6.Pages
{
    [Authorize]
    public partial class RazorDemo
    {
        public static object locker = new object();
        public string UserName { get; set; } = "Jack";

        public List<string> Hobbies { get; set; } = new List<string>() { "篮球", "睡觉" };

        public async Task<string> GetUserName()
        {
            return await Task.FromResult(UserName);
        }

        public string GetUserName<T>(T name)
        {
            return name.ToString();
        }
    }
}
