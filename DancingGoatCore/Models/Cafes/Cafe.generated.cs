//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;

using CMS;
using CMS.Base;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.DancingGoatCore;
using CMS.Helpers;

[assembly: RegisterDocumentType(Cafe.CLASS_NAME, typeof(Cafe))]

namespace CMS.DocumentEngine.Types.DancingGoatCore
{
    /// <summary>
    /// Represents a content item of type Cafe.
    /// </summary>
    public partial class Cafe : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DancingGoatCore.Cafe";


		/// <summary>
		/// The instance of the class that provides extended API for working with Cafe fields.
		/// </summary>
		private readonly CafeFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// CafeID.
		/// </summary>
		[DatabaseIDField]
		public int CafeID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("CafeID"), 0);
			}
			set
			{
				SetValue("CafeID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string CafeName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CafeName"), @"");
			}
			set
			{
				SetValue("CafeName", value);
			}
		}


		/// <summary>
		/// Our cafe.
		/// </summary>
		[DatabaseField]
		public bool CafeIsCompanyCafe
		{
			get
			{
				return ValidationHelper.GetBoolean(GetValue("CafeIsCompanyCafe"), false);
			}
			set
			{
				SetValue("CafeIsCompanyCafe", value);
			}
		}


		/// <summary>
		/// Street.
		/// </summary>
		[DatabaseField]
		public string CafeStreet
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CafeStreet"), @"");
			}
			set
			{
				SetValue("CafeStreet", value);
			}
		}


		/// <summary>
		/// City.
		/// </summary>
		[DatabaseField]
		public string CafeCity
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CafeCity"), @"");
			}
			set
			{
				SetValue("CafeCity", value);
			}
		}


		/// <summary>
		/// Country.
		/// </summary>
		[DatabaseField]
		public string CafeCountry
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CafeCountry"), @"USA");
			}
			set
			{
				SetValue("CafeCountry", value);
			}
		}


		/// <summary>
		/// Zip code.
		/// </summary>
		[DatabaseField]
		public string CafeZipCode
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CafeZipCode"), @"");
			}
			set
			{
				SetValue("CafeZipCode", value);
			}
		}


		/// <summary>
		/// Phone.
		/// </summary>
		[DatabaseField]
		public string CafePhone
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CafePhone"), @"");
			}
			set
			{
				SetValue("CafePhone", value);
			}
		}


		/// <summary>
		/// Photo.
		/// </summary>
		[DatabaseField]
		public Guid CafePhoto
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("CafePhoto"), Guid.Empty);
			}
			set
			{
				SetValue("CafePhoto", value);
			}
		}


		/// <summary>
		/// Additional notes.
		/// </summary>
		[DatabaseField]
		public string CafeAdditionalNotes
		{
			get
			{
				return ValidationHelper.GetString(GetValue("CafeAdditionalNotes"), @"");
			}
			set
			{
				SetValue("CafeAdditionalNotes", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Cafe fields.
		/// </summary>
		[RegisterProperty]
		public CafeFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Cafe fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class CafeFields : AbstractHierarchicalObject<CafeFields>
		{
			/// <summary>
			/// The content item of type Cafe that is a target of the extended API.
			/// </summary>
			private readonly Cafe mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="CafeFields" /> class with the specified content item of type Cafe.
			/// </summary>
			/// <param name="instance">The content item of type Cafe that is a target of the extended API.</param>
			public CafeFields(Cafe instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// CafeID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.CafeID;
				}
				set
				{
					mInstance.CafeID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.CafeName;
				}
				set
				{
					mInstance.CafeName = value;
				}
			}


			/// <summary>
			/// Our cafe.
			/// </summary>
			public bool IsCompanyCafe
			{
				get
				{
					return mInstance.CafeIsCompanyCafe;
				}
				set
				{
					mInstance.CafeIsCompanyCafe = value;
				}
			}


			/// <summary>
			/// Street.
			/// </summary>
			public string Street
			{
				get
				{
					return mInstance.CafeStreet;
				}
				set
				{
					mInstance.CafeStreet = value;
				}
			}


			/// <summary>
			/// City.
			/// </summary>
			public string City
			{
				get
				{
					return mInstance.CafeCity;
				}
				set
				{
					mInstance.CafeCity = value;
				}
			}


			/// <summary>
			/// Country.
			/// </summary>
			public string Country
			{
				get
				{
					return mInstance.CafeCountry;
				}
				set
				{
					mInstance.CafeCountry = value;
				}
			}


			/// <summary>
			/// Zip code.
			/// </summary>
			public string ZipCode
			{
				get
				{
					return mInstance.CafeZipCode;
				}
				set
				{
					mInstance.CafeZipCode = value;
				}
			}


			/// <summary>
			/// Phone.
			/// </summary>
			public string Phone
			{
				get
				{
					return mInstance.CafePhone;
				}
				set
				{
					mInstance.CafePhone = value;
				}
			}


			/// <summary>
			/// Photo.
			/// </summary>
			public DocumentAttachment Photo
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("CafePhoto");
				}
			}


			/// <summary>
			/// Additional notes.
			/// </summary>
			public string AdditionalNotes
			{
				get
				{
					return mInstance.CafeAdditionalNotes;
				}
				set
				{
					mInstance.CafeAdditionalNotes = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Cafe" /> class.
		/// </summary>
		public Cafe() : base(CLASS_NAME)
		{
			mFields = new CafeFields(this);
		}

		#endregion
	}
}