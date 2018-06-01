﻿
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportExecutionService
{
	[DebuggerStepThrough]
	[GeneratedCode("dotnet-svcutil", "0.3.0.0")]
	[MessageContract(WrapperName = "LoadReportDefinitionResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsWrapped = true)]
	public class LoadReportDefinitionResponse
	{
		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Order = 0)]
		public ExecutionInfo executionInfo;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Order = 1)]
		public Warning[] warnings;

		public LoadReportDefinitionResponse()
		{
		}

		public LoadReportDefinitionResponse(ExecutionInfo executionInfo, Warning[] warnings)
		{
			this.executionInfo = executionInfo;
			this.warnings = warnings;
		}
	}
}