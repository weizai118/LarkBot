﻿using Newbe.Mahua;
using System.Collections.Generic;

namespace Lark.Bot.CQA
{
    public class MyMenuProvider : IMahuaMenuProvider
    {
        public IEnumerable<MahuaMenu> GetMenus()
        {
            return new[]
            {
                new MahuaMenu
                {
                    Id = "menu1",
                    Text = "测试菜单1"
                },
                new MahuaMenu
                {
                    Id = "menu2",
                    Text = "测试菜单2"
                },
            };
        }
    }
}