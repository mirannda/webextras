﻿/*
* This file is part of - WebExtras
* Copyright (C) 2013 Mihir Mone
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

namespace WebExtras.Mvc.Html
{
  /// <summary>
  /// Represents an HTML B element
  /// </summary>
  [Serializable]
  public class Bold : HtmlElement
  {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="htmlAttributes">[Optional] Extra HTML attributes</param>
    public Bold(object htmlAttributes = null)
      : base(EHtmlTag.B, htmlAttributes)
    { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="innerHtml">Text to be displayed</param>
    /// <param name="htmlAttributes">[Optional] Extra HTML attributes</param>
    public Bold(string innerHtml, object htmlAttributes = null)
      : base(EHtmlTag.B, htmlAttributes)
    {
      InnerHtml = innerHtml;
    }
  }
}