using BlazorComponentUtilities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1.Components
{
    public partial class CButton: CComponentBase
    {
        /// <summary>
        /// 设置组件样式
        /// </summary>
        [Parameter]
        public ButtonStyle ButtonStyle { get; set; } 

        /// <summary>
        /// 设置组件显示文本
        /// </summary>
        [Parameter]
        public string Text { get; set; }

        /// <summary>
        /// 点击事件
        /// </summary>
        [Parameter]
        public EventCallback OnClick { get; set; }

        /// <summary>
        /// 宽度100%
        /// </summary>
        [Parameter]
        public bool IsFullWidth { get; set; }

        private string _buttonClasses => new CssBuilder()
            .AddClass("button")
            .AddClass(Class,!string.IsNullOrEmpty(Class))
            .AddClass("primary", ButtonStyle == ButtonStyle.Primary)
            .AddClass("secondary", ButtonStyle == ButtonStyle.Secondary)
            .Build();

        private string _buttonStyles => new StyleBuilder()
            .AddStyle("width", "100%", IsFullWidth)
            .Build();
    }

    public enum ButtonStyle
    {
        Primary,
        Secondary
    }
}
