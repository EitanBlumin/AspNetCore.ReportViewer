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
	public class ModelItem
	{
		private string idField;

		private string nameField;

		private string modelItemTypeNameField;

		private string descriptionField;

		private ModelItem[] modelItemsField;

		/// <remarks />
		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public string ModelItemTypeName
		{
			get
			{
				return this.modelItemTypeNameField;
			}
			set
			{
				this.modelItemTypeNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
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
		[XmlArray(Order = 4)]
		public ModelItem[] ModelItems
		{
			get
			{
				return this.modelItemsField;
			}
			set
			{
				this.modelItemsField = value;
			}
		}
	}
}