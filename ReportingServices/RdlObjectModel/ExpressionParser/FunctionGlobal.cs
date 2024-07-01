﻿using System;
using System.Text;

namespace Microsoft.ReportingServices.RdlObjectModel.ExpressionParser
{
  [Serializable]
  internal class FunctionGlobal : BaseInternalExpression
  {
    private readonly IInternalExpression m_nameExpr;

    public FunctionGlobal(IInternalExpression nameExpr)
    {
      m_nameExpr = nameExpr;
    }

    public override TypeCode TypeCode()
    {
      return System.TypeCode.Object;
    }

    public override string WriteSource(NameChanges nameChanges)
    {
      StringBuilder stringBuilder = new StringBuilder("Globals(");
      stringBuilder.Append(m_nameExpr.WriteSource(nameChanges));
      stringBuilder.Append(")");
      return stringBuilder.ToString();
    }

    protected override void TraverseChildren(ProcessInternalExpressionHandler callback)
    {
      base.TraverseChildren(callback);
      if (m_nameExpr == null)
        return;
      m_nameExpr.Traverse(callback);
    }
  }
}
