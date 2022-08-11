using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1
{
    public class CComponentBase : ComponentBase
    {
        /// <summary>
        /// 捕获其他属性
        /// </summary>

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UserAttributes { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// 设置组件Class
        /// </summary>
        [Parameter]
        public string Class { get; set; }

        /// <summary>
        /// 设置组件Style
        /// </summary>
        [Parameter]
        public string Style { get; set; }
    }
}
