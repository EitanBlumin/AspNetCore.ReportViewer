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
	[MessageContract(WrapperName = "NavigateBookmark", WrapperNamespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", IsWrapped = true)]
	public class NavigateBookmarkRequest
	{
		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/sqlserver/2005/06/30/reporting/reportingservices", Order = 0)]
		public string BookmarkID;

		public NavigateBookmarkRequest()
		{
		}

		public NavigateBookmarkRequest(string BookmarkID)
		{
			this.BookmarkID = BookmarkID;
		}
	}
}