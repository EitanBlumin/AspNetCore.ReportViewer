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
	[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	[MessageContract(WrapperName = "SetModelItemPolicies", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsWrapped = true)]
	public class SetModelItemPoliciesRequest
	{
		public TrustedUserHeader TrustedUserHeader;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 0)]
		public string Model;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 1)]
		public string ModelItemID;

		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", Order = 2)]
		public Policy[] Policies;

		public SetModelItemPoliciesRequest()
		{
		}

		public SetModelItemPoliciesRequest(TrustedUserHeader TrustedUserHeader, string Model, string ModelItemID, Policy[] Policies)
		{
			this.TrustedUserHeader = TrustedUserHeader;
			this.Model = Model;
			this.ModelItemID = ModelItemID;
			this.Policies = Policies;
		}
	}
}