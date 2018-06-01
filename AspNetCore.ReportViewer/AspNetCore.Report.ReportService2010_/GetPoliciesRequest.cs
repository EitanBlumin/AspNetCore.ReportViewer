﻿
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName = "GetPolicies", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetPoliciesRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string ItemPath;

		public GetPoliciesRequest()
		{
		}

		public GetPoliciesRequest(TrustedUserHeader TrustedUserHeader, string ItemPath)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.ItemPath = ItemPath;
		}
	}
}