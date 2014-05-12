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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebExtras.JQPlot;
using WebExtras.JQPlot.RendererOptions;
using WebExtras.JQPlot.SubOptions;

namespace WebExtras.DemoApp.Models.Core
{
  /// <summary>
  /// jqPlot dummy data creator
  /// </summary>
  public class GraphDataGenerator
  {
    private readonly object[][] m_graphSampleTextData1, m_graphSampleTextData2, m_graphSampleDateData, m_graphSampleOHLCData;
    private readonly Random m_rand;

    /// <summary>
    /// Sample data for a default graph
    /// </summary>
    public readonly double[][] GraphSampleData;

    public GraphDataGenerator()
    {
      m_rand = new Random(DateTime.Now.Millisecond);
      GraphSampleData = Enumerable.Range(1, 10).Select(f => new double[] { f, m_rand.NextDouble() * 100 }).ToArray();

      m_graphSampleTextData1 = new object[][] { 
        new object[] { "Cup Holder Pinion Bob", m_rand.NextDouble() * 100 },
        new object[] { "Generic Fog Lamp", m_rand.NextDouble() * 100 },
        new object[] { "HDTV Receiver", m_rand.NextDouble() * 100 },
        new object[] { "8 Track Control Module", m_rand.NextDouble() * 100 },
        new object[] { "Sludge Pump Fourier Modulator", m_rand.NextDouble() * 100 },
        new object[] { "Transcender/Spice Rack", m_rand.NextDouble() * 100 },
        new object[] { "Hair Spray Danger Indicator", m_rand.NextDouble() * 100 }
      };

      m_graphSampleTextData2 = new object[][] { 
        new object[] { "Nickel", m_rand.NextDouble() * 100 },
        new object[] { "Aluminium", m_rand.NextDouble() * 100 },
        new object[] { "Xenon", m_rand.NextDouble() * 100 },
        new object[] { "Silver", m_rand.NextDouble() * 100 },
        new object[] { "Sulphur", m_rand.NextDouble() * 100 },
        new object[] { "Vanadium", m_rand.NextDouble() * 100 },
        new object[] { "Uranium", m_rand.NextDouble() * 100 }
      };

      m_graphSampleDateData = new object[][]{
        new object[] { DateTime.Now.AddDays(m_rand.Next(150)).ToString("dd-MMM-yyyy"), m_rand.NextDouble() * 100 },
        new object[] { DateTime.Now.AddDays(m_rand.Next(150)).ToString("dd-MMM-yyyy"), m_rand.NextDouble() * 100 },
        new object[] { DateTime.Now.AddDays(m_rand.Next(150)).ToString("dd-MMM-yyyy"), m_rand.NextDouble() * 100 },
        new object[] { DateTime.Now.AddDays(m_rand.Next(150)).ToString("dd-MMM-yyyy"), m_rand.NextDouble() * 100 },
        new object[] { DateTime.Now.AddDays(m_rand.Next(150)).ToString("dd-MMM-yyyy"), m_rand.NextDouble() * 100 },
        new object[] { DateTime.Now.AddDays(m_rand.Next(150)).ToString("dd-MMM-yyyy"), m_rand.NextDouble() * 100 },
        new object[] { DateTime.Now.AddDays(m_rand.Next(150)).ToString("dd-MMM-yyyy"), m_rand.NextDouble() * 100 }
      };

      m_graphSampleOHLCData = Enumerable.Range(1, 25)
        .Select(i => new object[] {
          DateTime.Now.AddDays(3 * i).ToString("dd-MMM-yyyy hh:mm:ss"),
          m_rand.NextDouble() * 100,
          m_rand.NextDouble() * 100,
          m_rand.NextDouble() * 100,
          m_rand.NextDouble() * 100
        })
        .ToArray();
    }
    
    /// <summary>
    /// Get canned/dummy jqPlot
    /// </summary>
    /// <param name="mode">Mode for which to get the chart</param>
    /// <param name="url">Current UrlHelper to generate any AJAX call urls</param>
    /// <returns>A jqPlot chart</returns>
    public JQPlotChartBase GetJQPlotChart(int mode, UrlHelper url)
    {
      object data;
      JQPlotOptions options;

      switch (mode)
      {
        case 1:
          data = new List<object[][]> { m_graphSampleTextData1 };
          options = new JQPlotOptions
          {
            title = new TitleOptions("Concern vs Occurance"),
            axesDefaults = new JQPlot.SubOptions.AxisOptions
            {
              tickRenderer = EJQPlotRenderer.CanvasAxisTickRenderer,
              tickOptions = new CanvasAxisTickRendererOptions
              {
                angle = -30
              }
            },
            axes = new JQPlotAxes
            {
              xaxis = new JQPlot.SubOptions.AxisOptions { renderer = EJQPlotRenderer.CategoryAxisRenderer },
              yaxis = new JQPlot.SubOptions.AxisOptions
              {
                tickOptions = new CanvasAxisTickRendererOptions
                {
                  angle = 0
                }
              }
            },
            series = new JQPlot.SubOptions.SeriesOptions[]
            {
              new JQPlot.SubOptions.SeriesOptions {
                renderer = EJQPlotChartRenderer.BarRenderer
              }
            }
          };
          break;

        case 2:
          data = new List<object[][]> { m_graphSampleDateData };
          options = new JQPlotOptions
          {
            title = new TitleOptions("Date Data Rendering"),
            axes = new JQPlotAxes
            {
              xaxis = new JQPlot.SubOptions.AxisOptions
              {
                renderer = EJQPlotRenderer.DateAxisRenderer,
                tickOptions = new AxisTickRendererOptions
                {
                  formatString = "%b&nbsp;%#d"
                }
              },
            },
            series = new JQPlot.SubOptions.SeriesOptions[] 
            {
              new JQPlot.SubOptions.SeriesOptions 
              {
                renderer = EJQPlotChartRenderer.BarRenderer,
                rendererOptions = new BarRendererOptions {
                  barWidth = 25
                }
              }
            }
          };
          break;

        case 3:
          data = new List<object[][]> { m_graphSampleTextData1, m_graphSampleTextData2 };
          options = new JQPlotOptions
          {
            title = new TitleOptions("Concern vs Occurance"),
            axesDefaults = new JQPlot.SubOptions.AxisOptions
            {
              tickRenderer = EJQPlotRenderer.CanvasAxisTickRenderer,
              tickOptions = new CanvasAxisTickRendererOptions
              {
                angle = 30
              }
            },
            axes = new JQPlotAxes
            {
              xaxis = new JQPlot.SubOptions.AxisOptions { renderer = EJQPlotRenderer.CategoryAxisRenderer },
              x2axis = new JQPlot.SubOptions.AxisOptions { renderer = EJQPlotRenderer.CategoryAxisRenderer },
              yaxis = new JQPlot.SubOptions.AxisOptions
              {
                tickOptions = new CanvasAxisTickRendererOptions
                {
                  angle = 0
                },
                autoscale = true
              },
              y2axis = new JQPlot.SubOptions.AxisOptions
              {
                tickOptions = new CanvasAxisTickRendererOptions
                {
                  angle = 0
                },
                autoscale = true
              }
            },
            series = new JQPlot.SubOptions.SeriesOptions[]
            {
              new JQPlot.SubOptions.SeriesOptions {
                renderer = EJQPlotChartRenderer.BarRenderer
              },
              new JQPlot.SubOptions.SeriesOptions {
                xaxis = "x2axis",
                yaxis = "y2axis"
              }
            }
          };
          break;

        case 4:
          data = url.Action(MVC.GraphData.GetJQPlotData());
          options = new JQPlotOptions
          {
            title = new TitleOptions("AJAX JSON Data Renderer"),
            axesDefaults = new JQPlot.SubOptions.AxisOptions
            {
              labelRenderer = EJQPlotRenderer.CanvasAxisLabelRenderer,
              labelOptions = new Dictionary<string, object> { 
                { "fontSize", "12px" },
                { "fontFamily", "Arial" }
              }
            }
          };
          break;

        case 5:
          StringBuilder formatStringBuilder = new StringBuilder();
          formatStringBuilder.Append("<table class='jqplot-highlighter'>");
          formatStringBuilder.Append("<tr><td>date:</td><td>%s</td></tr>");
          formatStringBuilder.Append("<tr><td>open:</td><td>%s</td></tr>");
          formatStringBuilder.Append("<tr><td>hi:</td><td>%s</td></tr>");
          formatStringBuilder.Append("<tr><td>low:</td><td>%s</td></tr>");
          formatStringBuilder.Append("<tr><td>close:</td><td>%s</td></tr>");
          formatStringBuilder.Append("</table>");

          data = new List<object[][]> { m_graphSampleOHLCData };
          options = new JQPlotOptions
          {
            seriesDefaults = new JQPlot.SubOptions.SeriesOptions
            {
              yaxis = "y2axis"
            },
            axes = new JQPlotAxes
            {
              xaxis = new JQPlot.SubOptions.AxisOptions
              {
                renderer = EJQPlotRenderer.DateAxisRenderer,
                tickOptions = new AxisTickRendererOptions
                {
                  formatString = "%b %e"
                },
                tickInterval = "6 weeks"
              },
              y2axis = new JQPlot.SubOptions.AxisOptions
              {
                tickOptions = new AxisTickRendererOptions
                {
                  formatString = "$%d"
                }
              }
            },
            series = new JQPlot.SubOptions.SeriesOptions[] {
              new JQPlot.SubOptions.SeriesOptions {
                renderer = EJQPlotChartRenderer.OHLCRenderer,
                rendererOptions = new OHLCRendererOptions {
                  candleStick = true
                }
              }
            },
            highlighter = new HighlighterOptions
            {
              show = true,
              showMarker = false,
              tooltipAxes = "xy",
              yvalues = 4,
              formatString = formatStringBuilder.ToString()
            }
          };
          break;

        default:
          data = new List<double[][]> { GraphSampleData };
          options = new JQPlotOptions
          {
            title = new TitleOptions("Basic Line Graph"),
            axesDefaults = new JQPlot.SubOptions.AxisOptions
            {
              labelRenderer = EJQPlotRenderer.CanvasAxisLabelRenderer,
              labelOptions = new Dictionary<string, object> { 
                { "fontSize", "12px" },
                { "fontFamily", "Arial" }
              }
            },
            axes = new JQPlotAxes
            {
              xaxis = new JQPlot.SubOptions.AxisOptions { label = "X Axis" },
              yaxis = new JQPlot.SubOptions.AxisOptions { label = "Y Axis" }
            }
          };
          break;
      }

      JQPlotChartBase chart = new JQPlotChartBase
      {
        chartData = data,
        chartOptions = options
      };

      return chart;
    }
  }
}