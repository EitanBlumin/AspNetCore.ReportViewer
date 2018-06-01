﻿
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	[MessageContract(WrapperName = "DeleteCacheRefreshPlanResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class DeleteCacheRefreshPlanResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		public DeleteCacheRefreshPlanResponse()
		{
		}

		public DeleteCacheRefreshPlanResponse(ServerInfoHeader ServerInfoHeader)
		{
			this.ServerInfoHeader = ServerInfoHeader;
		}
	}
}