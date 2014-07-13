﻿/*
* This file is part of - WebExtras
* Copyright (C) 2014 Mihir Mone
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU Lesser General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU Lesser General Public License for more details.
*
* You should have received a copy of the GNU Lesser General Public License
* along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Web.Mvc;
using System.Web.Routing;
using WebExtras.Mvc.Html;

namespace WebExtras.Mvc.Core
{
  /// <summary>
  /// Utility methods
  /// </summary>
  public static class HtmlStringUtil
  {
    /// <summary>
    /// Check whether we can actually display as button
    /// </summary>
    /// <param name="html">Current HTML element</param>
    /// <returns>True if can display as button, else False</returns>
    public static bool CanDisplayAsButton(IExtendedHtmlString html)
    {
      // We can only display hyperlinks and button as buttons
      Type t = html.GetType();

      return t == typeof(Hyperlink) || t == typeof(Button);
    }

    /// <summary>
    /// Get the url from given action result
    /// </summary>
    /// <param name="html">Current HTML helper instance</param>
    /// <param name="result">Action to be parsed</param>
    /// <returns>The URL the action points to</returns>
    public static string GetUrl(HtmlHelper html, ActionResult result)
    {
      UrlHelper urlHelper = new UrlHelper(html.ViewContext.RequestContext);

      RouteValueDictionary rvd = result.GetRouteValueDictionary();
      string link = urlHelper.RouteUrl(rvd);

      return link;
    }
  }
}
