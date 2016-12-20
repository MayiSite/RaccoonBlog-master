using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RaccoonBlog.Web.Areas.Admin.Models;

namespace RaccoonBlog.Web.Areas.Admin.Helpers
{
    using RaccoonBlog.Web.Areas.Admin.Enums;

    public static class MenuUtil
	{
		public static IList<MenuItem> GetTopMenu(UrlHelper url)
		{
			var items = new List<MenuItem>
			{
				new MenuItem {Title = "返回博客", Url = url.RouteUrl("homepage"), Type = MenuButtonType.Plain},
				new MenuItem {Title = "文章", Url = url.Action("Index", "Posts"), Type = MenuButtonType.Plain},
                new MenuItem {Title = "新增文章", Url = url.Action("Add", "Posts"), Type = MenuButtonType.Add},
				new MenuItem {Title = "部分页", Url = url.Action("Index", "Sections"), Type = MenuButtonType.Plain},
                new MenuItem {Title = "新增部分页", Url = url.Action("Add", "Sections"), Type = MenuButtonType.Add},
				new MenuItem {Title = "用户", Url = url.Action("Index", "Users"), Type = MenuButtonType.Plain},
                new MenuItem {Title = "新增用户", Url = url.Action("Add", "Users"), Type = MenuButtonType.Add},
				new MenuItem {Title = "设置", Type = MenuButtonType.Toggle,
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem {Title = "配置", Url = url.Action("Index", "Settings"), Type = MenuButtonType.Plain},
                        new MenuItem {Title = "RSS 访问", Url = url.Action("RssFutureAccess", "Settings"), Type = MenuButtonType.Plain},
                        new MenuItem {Title = "Reddit 提交", Url = url.Action("RedditSubmission", "Settings"), Type = MenuButtonType.Plain},
                    }
				},
			};

			AnalyzeMenuItems(items, url.RequestContext.HttpContext.Request.Url ?? new Uri("/"));
			

			return items;
		}

		private static void AnalyzeMenuItems(IEnumerable<MenuItem> items, Uri currentUri)
		{
			foreach (var menu in items)
			{
				if (menu.SubMenus != null)
				{
					if (menu.Url == null)
					{
						menu.Url = (menu.SubMenus.FirstOrDefault() ?? new MenuItem()).Url;
					}
					AnalyzeMenuItems(menu.SubMenus, currentUri);
				}
				menu.IsCurrent = currentUri.PathAndQuery == menu.Url;
			}
		}
	}
}