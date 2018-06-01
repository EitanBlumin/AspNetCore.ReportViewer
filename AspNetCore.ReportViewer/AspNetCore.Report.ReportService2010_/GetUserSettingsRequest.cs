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
	[MessageContract(WrapperName = "GetUserSettings", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetUserSettingsRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public Property[] Properties;

		public GetUserSettingsRequest()
		{
		}

		public GetUserSettingsRequest(TrustedUserHeader TrustedUserHeader, Property[] Properties)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.Properties = Properties;
		}
	}
}