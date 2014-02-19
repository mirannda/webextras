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

#pragma warning disable 1591

using WebExtras.JQDataTables;

namespace WebExtras.DemoApp.Models.Core
{
  public class DatatablesViewModel
  {
    public int DisplayMode { get; set; }

    public Datatable Table { get; set; }

    public Datatable PostbackEnabledTable { get; set; }

    public PostbackSetupViewModel PostbackFormFields { get; set; }
  }
}