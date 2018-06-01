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
	public class ItemParameter
	{
		private string nameField;

		private string parameterTypeNameField;

		private bool nullableField;

		private bool nullableFieldSpecified;

		private bool allowBlankField;

		private bool allowBlankFieldSpecified;

		private bool multiValueField;

		private bool multiValueFieldSpecified;

		private bool queryParameterField;

		private bool queryParameterFieldSpecified;

		private string promptField;

		private bool promptUserField;

		private bool promptUserFieldSpecified;

		private string[] dependenciesField;

		private bool validValuesQueryBasedField;

		private bool validValuesQueryBasedFieldSpecified;

		private ValidValue[] validValuesField;

		private bool defaultValuesQueryBasedField;

		private bool defaultValuesQueryBasedFieldSpecified;

		private string[] defaultValuesField;

		private string parameterStateNameField;

		private string errorMessageField;

		/// <remarks />
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public string ParameterTypeName
		{
			get
			{
				return this.parameterTypeNameField;
			}
			set
			{
				this.parameterTypeNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 2)]
		public bool Nullable
		{
			get
			{
				return this.nullableField;
			}
			set
			{
				this.nullableField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool NullableSpecified
		{
			get
			{
				return this.nullableFieldSpecified;
			}
			set
			{
				this.nullableFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 3)]
		public bool AllowBlank
		{
			get
			{
				return this.allowBlankField;
			}
			set
			{
				this.allowBlankField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool AllowBlankSpecified
		{
			get
			{
				return this.allowBlankFieldSpecified;
			}
			set
			{
				this.allowBlankFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 4)]
		public bool MultiValue
		{
			get
			{
				return this.multiValueField;
			}
			set
			{
				this.multiValueField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool MultiValueSpecified
		{
			get
			{
				return this.multiValueFieldSpecified;
			}
			set
			{
				this.multiValueFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 5)]
		public bool QueryParameter
		{
			get
			{
				return this.queryParameterField;
			}
			set
			{
				this.queryParameterField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool QueryParameterSpecified
		{
			get
			{
				return this.queryParameterFieldSpecified;
			}
			set
			{
				this.queryParameterFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 6)]
		public string Prompt
		{
			get
			{
				return this.promptField;
			}
			set
			{
				this.promptField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 7)]
		public bool PromptUser
		{
			get
			{
				return this.promptUserField;
			}
			set
			{
				this.promptUserField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool PromptUserSpecified
		{
			get
			{
				return this.promptUserFieldSpecified;
			}
			set
			{
				this.promptUserFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 8)]
		[XmlArrayItem("Dependency")]
		public string[] Dependencies
		{
			get
			{
				return this.dependenciesField;
			}
			set
			{
				this.dependenciesField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 9)]
		public bool ValidValuesQueryBased
		{
			get
			{
				return this.validValuesQueryBasedField;
			}
			set
			{
				this.validValuesQueryBasedField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool ValidValuesQueryBasedSpecified
		{
			get
			{
				return this.validValuesQueryBasedFieldSpecified;
			}
			set
			{
				this.validValuesQueryBasedFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 10)]
		public ValidValue[] ValidValues
		{
			get
			{
				return this.validValuesField;
			}
			set
			{
				this.validValuesField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 11)]
		public bool DefaultValuesQueryBased
		{
			get
			{
				return this.defaultValuesQueryBasedField;
			}
			set
			{
				this.defaultValuesQueryBasedField = value;
			}
		}

		/// <remarks />
		[XmlIgnore]
		public bool DefaultValuesQueryBasedSpecified
		{
			get
			{
				return this.defaultValuesQueryBasedFieldSpecified;
			}
			set
			{
				this.defaultValuesQueryBasedFieldSpecified = value;
			}
		}

		/// <remarks />
		[XmlArray(Order = 12)]
		[XmlArrayItem("Value")]
		public string[] DefaultValues
		{
			get
			{
				return this.defaultValuesField;
			}
			set
			{
				this.defaultValuesField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 13)]
		public string ParameterStateName
		{
			get
			{
				return this.parameterStateNameField;
			}
			set
			{
				this.parameterStateNameField = value;
			}
		}

		/// <remarks />
		[XmlElement(Order = 14)]
		public string ErrorMessage
		{
			get
			{
				return this.errorMessageField;
			}
			set
			{
				this.errorMessageField = value;
			}
		}
	}
}