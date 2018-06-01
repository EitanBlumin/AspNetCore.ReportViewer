﻿
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;


namespace AspNetCore.Report.ReportExecutionService
{
	/// <remarks />
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices")]
	public class ExecutionHeader
	{
		private string executionIDField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string ExecutionID
		{
			get
			{
				return this.executionIDField;
			}
			set
			{
				this.executionIDField = value;
			}
		}
	}
}