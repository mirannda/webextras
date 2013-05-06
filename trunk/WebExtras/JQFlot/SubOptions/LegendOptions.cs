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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WebExtras.JQFlot.SubOptions
{
  /// <summary>
  /// Represents Flot legend options
  /// </summary>
  public class LegendOptions
  {
    /// <summary>
    /// Flag indicating whether to show legend
    /// </summary>
    public bool? show;

    /// <summary>
    /// Color of the label box border. This must be a CSS color specification
    /// </summary>
    public string labelBoxBorderColor;

    /// <summary>
    /// Number of columns per row of the legend's table
    /// </summary>
    public int? noColumns;

    /// <summary>
    /// Position of the legend. Can be one of 'ne', 'nw', 'se' or 'sw'.
    /// </summary>
    public string position;

    /// <summary>
    /// The margin in pixels or a numeric array with x and y margin in pixels
    /// </summary>
    public object margin;

    /// <summary>
    /// Background color of the legend. This must be a CSS color specification
    /// </summary>
    public string backgroundColor;

    /// <summary>
    /// Background opacity of the legend. This must be a value between 0 and 1
    /// </summary>
    public double backgroundOpacity;

    /// <summary>
    /// Specify sorting to be applied to the legend objects
    /// </summary>
    public ELegendSort? sorted;
  }
}
