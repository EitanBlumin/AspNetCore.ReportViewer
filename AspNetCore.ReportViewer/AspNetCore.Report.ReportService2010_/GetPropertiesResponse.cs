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
	[MessageContract(WrapperName = "GetPropertiesResponse", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetPropertiesResponse
	{
		[MessageHeader]
		public ServerInfoHeader ServerInfoHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public Property[] Values;

		public GetPropertiesResponse()
		{
		}

		public GetPropertiesResponse(ServerInfoHeader ServerInfoHeader, Property[] Values)
		{
			this.ServerInfoHeader = ServerInfoHeader;
			this.Values = Values;
		}
	}
}