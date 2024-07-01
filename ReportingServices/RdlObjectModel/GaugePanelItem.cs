﻿using System.ComponentModel;
using System.Xml.Serialization;

namespace Microsoft.ReportingServices.RdlObjectModel
{
  public class GaugePanelItem : ReportObject, INamedObject
  {
    [XmlAttribute(typeof (string))]
    public string Name
    {
      get
      {
        return (string) PropertyStore.GetObject(0);
      }
      set
      {
        PropertyStore.SetObject(0, value);
      }
    }

    public Style Style
    {
      get
      {
        return (Style) PropertyStore.GetObject(1);
      }
      set
      {
        PropertyStore.SetObject(1, value);
      }
    }

    [ReportExpressionDefaultValue(typeof (double), 0.0)]
    public ReportExpression<double> Top
    {
      get
      {
        return PropertyStore.GetObject<ReportExpression<double>>(2);
      }
      set
      {
        PropertyStore.SetObject(2, value);
      }
    }

    [ReportExpressionDefaultValue(typeof (double), 0.0)]
    public ReportExpression<double> Left
    {
      get
      {
        return PropertyStore.GetObject<ReportExpression<double>>(3);
      }
      set
      {
        PropertyStore.SetObject(3, value);
      }
    }

    [ReportExpressionDefaultValue(typeof (double), 0.0)]
    public ReportExpression<double> Height
    {
      get
      {
        return PropertyStore.GetObject<ReportExpression<double>>(4);
      }
      set
      {
        PropertyStore.SetObject(4, value);
      }
    }

    [ReportExpressionDefaultValue(typeof (double), 0.0)]
    public ReportExpression<double> Width
    {
      get
      {
        return PropertyStore.GetObject<ReportExpression<double>>(5);
      }
      set
      {
        PropertyStore.SetObject(5, value);
      }
    }

    [ReportExpressionDefaultValue(typeof (int), 0)]
    public ReportExpression<int> ZIndex
    {
      get
      {
        return PropertyStore.GetObject<ReportExpression<int>>(6);
      }
      set
      {
        PropertyStore.SetObject(6, value);
      }
    }

    [ReportExpressionDefaultValue(typeof (bool), false)]
    public ReportExpression<bool> Hidden
    {
      get
      {
        return PropertyStore.GetObject<ReportExpression<bool>>(7);
      }
      set
      {
        PropertyStore.SetObject(7, value);
      }
    }

    [ReportExpressionDefaultValue]
    public ReportExpression ToolTip
    {
      get
      {
        return PropertyStore.GetObject<ReportExpression>(8);
      }
      set
      {
        PropertyStore.SetObject(8, value);
      }
    }

    public ActionInfo ActionInfo
    {
      get
      {
        return (ActionInfo) PropertyStore.GetObject(9);
      }
      set
      {
        PropertyStore.SetObject(9, value);
      }
    }

    [DefaultValue("")]
    public string ParentItem
    {
      get
      {
        return (string) PropertyStore.GetObject(10);
      }
      set
      {
        PropertyStore.SetObject(10, value);
      }
    }

    public GaugePanelItem()
    {
    }

    internal GaugePanelItem(IPropertyStore propertyStore)
      : base(propertyStore)
    {
    }

    internal class Definition : DefinitionStore<GaugePanelItem, Definition.Properties>
    {
      private Definition()
      {
      }

      internal enum Properties
      {
        Name,
        Style,
        Top,
        Left,
        Height,
        Width,
        ZIndex,
        Hidden,
        ToolTip,
        ActionInfo,
        ParentItem,
        PropertyCount,
      }
    }
  }
}
