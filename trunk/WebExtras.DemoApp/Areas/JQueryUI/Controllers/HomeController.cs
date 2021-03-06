﻿/*
* This file is part of - WebExtras Demo application
* Copyright (C) 2014 Mihir Mone
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU Lesser General Public License as published by
* the Free Software Foundation, either version 2 of the License, or
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

using System.Web.Mvc;

namespace WebExtras.DemoApp.Areas.JQueryUI.Controllers
{
  public partial class HomeController : BaseController
  {
    //
    // GET: /JQueryUI/Home/
    public virtual ActionResult Index()
    {
      return View(MVC.Home.Views.Index);
    }

    //
    // GET: /JQueryUI/Home/Download
    public virtual ActionResult Download()
    {
      return View(model: m_versionString);
    }
  }
}
