﻿
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ServiceModel;


namespace AspNetCore.Report.ReportService2010_
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[MessageContract(WrapperName = "GetCacheRefreshPlanProperties", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class GetCacheRefreshPlanPropertiesRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string CacheRefreshPlanID;

		public GetCacheRefreshPlanPropertiesRequest()
		{
		}

		public GetCacheRefreshPlanPropertiesRequest(TrustedUserHeader TrustedUserHeader, string CacheRefreshPlanID)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.CacheRefreshPlanID = CacheRefreshPlanID;
		}
	}
}