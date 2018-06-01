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
	/// <remarks />
	[GeneratedCode("svcutil", "4.6.1055.0")]
	[DataContract]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
	public class ModelCatalogItem
	{
		private string modelField;

		private string descriptionField;

		private ModelPerspective[] perspectivesField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string Model
		{
			get
			{
				return this.modelField;
			}
			set
			{
				this.modelField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 2)]
		public ModelPerspective[] Perspectives
		{
			get
			{
				return this.perspectivesField;
			}
			set
			{
				this.perspectivesField = value;
			}
		}
	}
}