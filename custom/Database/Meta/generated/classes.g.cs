namespace Allors.Meta
{
    public partial class MetaOrganisation : MetaClass
	{
	    public static MetaOrganisation Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType Name;
        public RoleType Employees;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;
        public ConcreteRoleType Locale;

		// Defined Associations

		// Inherited Associations


		internal MetaOrganisation(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("3a5dcec7-308f-48c7-afee-35d38415aa0b"))
			{
				SingularName = "Organisation",
				PluralName = "Organisations",
			};
        }

	}

    public partial class MetaPerson : MetaClass
	{
	    public static MetaPerson Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType Delete;
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType Picture;
        public RoleType FirstName;
        public RoleType LastName;
        public RoleType MiddleName;

		// Inherited Roles
        public ConcreteRoleType UserEmailConfirmed;
        public ConcreteRoleType UserName;
        public ConcreteRoleType NormalizedUserName;
        public ConcreteRoleType UserEmail;
        public ConcreteRoleType UserPasswordHash;
        public ConcreteRoleType TaskList;
        public ConcreteRoleType NotificationList;
        public ConcreteRoleType OwnerSecurityToken;
        public ConcreteRoleType OwnerAccessControl;
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;
        public ConcreteRoleType UniqueId;

		// Defined Associations
        public AssociationType OrganisationsWhereEmployee;
        public AssociationType TasksWhereParticipant;
        public AssociationType TasksWherePerformer;

		// Inherited Associations
        public AssociationType SingletonWhereGuest;
        public AssociationType AccessControlsWhereSubject;
        public AssociationType AccessControlsWhereEffectiveUser;
        public AssociationType LoginsWhereUser;
        public AssociationType EmailMessagesWhereSender;
        public AssociationType EmailMessagesWhereRecipient;
        public AssociationType TaskAssignmentsWhereUser;
        public AssociationType UserGroupsWhereMember;
        public AssociationType NotificationsWhereTarget;


		internal MetaPerson(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("c799ca62-a554-467d-9aa2-1663293bb37f"))
			{
				SingularName = "Person",
				PluralName = "People",
			};
        }

	}

    public partial class MetaSettings : MetaClass
	{
	    public static MetaSettings Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType Counter;
        public RoleType Setting;

		// Inherited Roles

		// Defined Associations
        public AssociationType SingletonWhereSettings;

		// Inherited Associations


		internal MetaSettings(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("DC94D0BF-E08D-4B01-A91F-723CED6F3C36"))
			{
				SingularName = "Settings",
				PluralName = "Setingses",
			};
        }

	}

    public partial class MetaSingleton : MetaClass
	{
	    public static MetaSingleton Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType AdministratorSecurityToken;
        public RoleType Settings;
        public RoleType DefaultLocale;
        public RoleType AdditionalLocales;
        public RoleType Guest;
        public RoleType InitialSecurityToken;
        public RoleType DefaultSecurityToken;
        public RoleType CreatorsAccessControl;
        public RoleType GuestAccessControl;
        public RoleType AdministratorsAccessControl;
        public RoleType LogoImage;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations

		// Inherited Associations


		internal MetaSingleton(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("313b97a5-328c-4600-9dd2-b5bc146fb13b"))
			{
				SingularName = "Singleton",
				PluralName = "Singletons",
			};
        }

	}

    public partial class MetaCounter : MetaClass
	{
	    public static MetaCounter Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType Value;

		// Inherited Roles
        public ConcreteRoleType UniqueId;

		// Defined Associations
        public AssociationType SettingsWhereCounter;

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;


		internal MetaCounter(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("0568354f-e3d9-439e-baac-b7dce31b956a"))
			{
				SingularName = "Counter",
				PluralName = "Counters",
			};
        }

	}

    public partial class MetaMedia : MetaClass
	{
	    public static MetaMedia Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType Revision;
        public RoleType MediaContent;
        public RoleType InData;
        public RoleType InDataUri;
        public RoleType FileName;
        public RoleType Type;

		// Inherited Roles
        public ConcreteRoleType UniqueId;
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations
        public AssociationType PersonWherePicture;
        public AssociationType SingletonsWhereLogoImage;
        public AssociationType TemplateWhereMedia;

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;


		internal MetaMedia(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("da5b86a3-4f33-4c0d-965d-f4fbc1179374"))
			{
				SingularName = "Media",
				PluralName = "Medias",
			};
        }

	}

    public partial class MetaMediaContent : MetaClass
	{
	    public static MetaMediaContent Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType Type;
        public RoleType Data;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations
        public AssociationType MediaWhereMediaContent;

		// Inherited Associations


		internal MetaMediaContent(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("6c20422e-cb3e-4402-bb40-dacaf584405e"))
			{
				SingularName = "MediaContent",
				PluralName = "MediaContents",
			};
        }

	}

    public partial class MetaTemplate : MetaClass
	{
	    public static MetaTemplate Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType TemplateType;
        public RoleType Media;
        public RoleType Arguments;

		// Inherited Roles
        public ConcreteRoleType UniqueId;
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;


		internal MetaTemplate(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("93F8B97B-2D9A-42FC-A823-7BDCC5A92203"))
			{
				SingularName = "Template",
				PluralName = "Templates",
			};
        }

	}

    public partial class MetaTemplateType : MetaClass
	{
	    public static MetaTemplateType Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles

		// Inherited Roles
        public ConcreteRoleType UniqueId;
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;
        public ConcreteRoleType Name;
        public ConcreteRoleType LocalisedNames;
        public ConcreteRoleType IsActive;

		// Defined Associations
        public AssociationType TemplatesWhereTemplateType;

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;


		internal MetaTemplateType(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("BDABB545-3B39-4F91-9D01-A589A5DA670E"))
			{
				SingularName = "TemplateType",
				PluralName = "TemplateTypes",
			};
        }

	}

    public partial class MetaPreparedExtent : MetaClass
	{
	    public static MetaPreparedExtent Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType Name;
        public RoleType Description;
        public RoleType Content;

		// Inherited Roles
        public ConcreteRoleType UniqueId;

		// Defined Associations

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;


		internal MetaPreparedExtent(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("645A4F92-F1F1-41C7-BA76-53A1CC4D2A61"))
			{
				SingularName = "PreparedExtent",
				PluralName = "PreparedExtents",
			};
        }

	}

    public partial class MetaPreparedFetch : MetaClass
	{
	    public static MetaPreparedFetch Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType Name;
        public RoleType Description;
        public RoleType Content;

		// Inherited Roles
        public ConcreteRoleType UniqueId;

		// Defined Associations

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;


		internal MetaPreparedFetch(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("02C7569C-8F54-4F8D-AC09-1BACD9528F1F"))
			{
				SingularName = "PreparedFetch",
				PluralName = "PreparedFetches",
			};
        }

	}

    public partial class MetaCountry : MetaClass
	{
	    public static MetaCountry Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType Currency;
        public RoleType IsoCode;
        public RoleType Name;
        public RoleType LocalisedNames;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations
        public AssociationType LocalesWhereCountry;

		// Inherited Associations


		internal MetaCountry(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("c22bf60e-6428-4d10-8194-94f7be396f28"))
			{
				SingularName = "Country",
				PluralName = "Countries",
			};
        }

	}

    public partial class MetaCurrency : MetaClass
	{
	    public static MetaCurrency Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType IsoCode;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;
        public ConcreteRoleType UniqueId;
        public ConcreteRoleType Name;
        public ConcreteRoleType LocalisedNames;
        public ConcreteRoleType IsActive;

		// Defined Associations
        public AssociationType CountriesWhereCurrency;

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;


		internal MetaCurrency(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("fd397adf-40b4-4ef8-b449-dd5a24273df3"))
			{
				SingularName = "Currency",
				PluralName = "Currencies",
			};
        }

	}

    public partial class MetaLanguage : MetaClass
	{
	    public static MetaLanguage Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType IsoCode;
        public RoleType Name;
        public RoleType LocalisedNames;
        public RoleType NativeName;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations
        public AssociationType LocalesWhereLanguage;

		// Inherited Associations


		internal MetaLanguage(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("4a0eca4b-281f-488d-9c7e-497de882c044"))
			{
				SingularName = "Language",
				PluralName = "Languages",
			};
        }

	}

    public partial class MetaLocale : MetaClass
	{
	    public static MetaLocale Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType Name;
        public RoleType Language;
        public RoleType Country;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations
        public AssociationType SingletonsWhereDefaultLocale;
        public AssociationType SingletonWhereAdditionalLocale;
        public AssociationType LocalisedsWhereLocale;

		// Inherited Associations


		internal MetaLocale(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("45033ae6-85b5-4ced-87ce-02518e6c27fd"))
			{
				SingularName = "Locale",
				PluralName = "Locales",
			};
        }

	}

    public partial class MetaLocalisedText : MetaClass
	{
	    public static MetaLocalisedText Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType Text;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;
        public ConcreteRoleType Locale;

		// Defined Associations
        public AssociationType CountryWhereLocalisedName;
        public AssociationType LanguageWhereLocalisedName;
        public AssociationType EnumerationWhereLocalisedName;

		// Inherited Associations


		internal MetaLocalisedText(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("020f5d4d-4a59-4d7b-865a-d72fc70e4d97"))
			{
				SingularName = "LocalisedText",
				PluralName = "LocalisedTexts",
			};
        }

	}

    public partial class MetaAccessControl : MetaClass
	{
	    public static MetaAccessControl Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType SubjectGroups;
        public RoleType Subjects;
        public RoleType Role;
        public RoleType EffectivePermissions;
        public RoleType EffectiveUsers;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;
        public ConcreteRoleType CacheId;

		// Defined Associations
        public AssociationType SingletonWhereCreatorsAccessControl;
        public AssociationType SingletonWhereGuestAccessControl;
        public AssociationType SingletonWhereAdministratorsAccessControl;
        public AssociationType SecurityTokensWhereAccessControl;
        public AssociationType SecurityTokenOwnerWhereOwnerAccessControl;

		// Inherited Associations


		internal MetaAccessControl(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("c4d93d5e-34c3-4731-9d37-47a8e801d9a8"))
			{
				SingularName = "AccessControl",
				PluralName = "AccessControls",
			};
        }

	}

    public partial class MetaLogin : MetaClass
	{
	    public static MetaLogin Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType Key;
        public RoleType Provider;
        public RoleType User;

		// Inherited Roles

		// Defined Associations

		// Inherited Associations


		internal MetaLogin(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("ad7277a8-eda4-4128-a990-b47fe43d120a"))
			{
				SingularName = "Login",
				PluralName = "Logins",
			};
        }

	}

    public partial class MetaPermission : MetaClass
	{
	    public static MetaPermission Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType OperandTypePointer;
        public RoleType ConcreteClassPointer;
        public RoleType OperationEnum;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations
        public AssociationType AccessControlsWhereEffectivePermission;
        public AssociationType RolesWherePermission;
        public AssociationType AccessControlledObjectsWhereDeniedPermission;
        public AssociationType ObjectStatesWhereDeniedPermission;

		// Inherited Associations


		internal MetaPermission(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("7fded183-3337-4196-afb0-3266377944bc"))
			{
				SingularName = "Permission",
				PluralName = "Permissions",
			};
        }

	}

    public partial class MetaRole : MetaClass
	{
	    public static MetaRole Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType Permissions;
        public RoleType Name;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;
        public ConcreteRoleType UniqueId;

		// Defined Associations
        public AssociationType AccessControlsWhereRole;

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;


		internal MetaRole(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("af6fe5f4-e5bc-4099-bcd1-97528af6505d"))
			{
				SingularName = "Role",
				PluralName = "Roles",
			};
        }

	}

    public partial class MetaSecurityToken : MetaClass
	{
	    public static MetaSecurityToken Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType AccessControls;

		// Inherited Roles

		// Defined Associations
        public AssociationType SingletonsWhereAdministratorSecurityToken;
        public AssociationType SingletonsWhereInitialSecurityToken;
        public AssociationType SingletonsWhereDefaultSecurityToken;
        public AssociationType AccessControlledObjectsWhereSecurityToken;
        public AssociationType SecurityTokenOwnerWhereOwnerSecurityToken;

		// Inherited Associations


		internal MetaSecurityToken(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("a53f1aed-0e3f-4c3c-9600-dc579cccf893"))
			{
				SingularName = "SecurityToken",
				PluralName = "SecurityTokens",
			};
        }

	}

    public partial class MetaAutomatedAgent : MetaClass
	{
	    public static MetaAutomatedAgent Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType Name;
        public RoleType Description;

		// Inherited Roles
        public ConcreteRoleType OwnerSecurityToken;
        public ConcreteRoleType OwnerAccessControl;
        public ConcreteRoleType UserEmailConfirmed;
        public ConcreteRoleType UserName;
        public ConcreteRoleType NormalizedUserName;
        public ConcreteRoleType UserEmail;
        public ConcreteRoleType UserPasswordHash;
        public ConcreteRoleType TaskList;
        public ConcreteRoleType NotificationList;
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations

		// Inherited Associations
        public AssociationType SingletonWhereGuest;
        public AssociationType AccessControlsWhereSubject;
        public AssociationType AccessControlsWhereEffectiveUser;
        public AssociationType LoginsWhereUser;
        public AssociationType EmailMessagesWhereSender;
        public AssociationType EmailMessagesWhereRecipient;
        public AssociationType TaskAssignmentsWhereUser;
        public AssociationType UserGroupsWhereMember;


		internal MetaAutomatedAgent(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("3587d2e1-c3f6-4c55-a96c-016e0501d99c"))
			{
				SingularName = "AutomatedAgent",
				PluralName = "AutomatedAgents",
			};
        }

	}

    public partial class MetaEmailMessage : MetaClass
	{
	    public static MetaEmailMessage Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType DateCreated;
        public RoleType DateSending;
        public RoleType DateSent;
        public RoleType Sender;
        public RoleType Recipients;
        public RoleType RecipientEmailAddress;
        public RoleType Subject;
        public RoleType Body;

		// Inherited Roles

		// Defined Associations

		// Inherited Associations


		internal MetaEmailMessage(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("ab20998b-62b1-4064-a7b9-cc9416edf77a"))
			{
				SingularName = "EmailMessage",
				PluralName = "EmailMessages",
			};
        }

	}

    public partial class MetaNotification : MetaClass
	{
	    public static MetaNotification Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType Target;
        public RoleType Confirmed;
        public RoleType Title;
        public RoleType Description;
        public RoleType DateCreated;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations
        public AssociationType NotificationListWhereNotification;
        public AssociationType NotificationListWhereUnconfirmedNotification;
        public AssociationType NotificationListWhereConfirmedNotification;
        public AssociationType TaskAssignmentWhereNotification;

		// Inherited Associations


		internal MetaNotification(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("73dcdc68-7571-4ed1-86db-77c914fe2f62"))
			{
				SingularName = "Notification",
				PluralName = "Notifications",
			};
        }

	}

    public partial class MetaNotificationList : MetaClass
	{
	    public static MetaNotificationList Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType Notifications;
        public RoleType UnconfirmedNotifications;
        public RoleType ConfirmedNotifications;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations
        public AssociationType UserWhereNotificationList;

		// Inherited Associations


		internal MetaNotificationList(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("b6579993-4ff1-4853-b048-1f8e67419c00"))
			{
				SingularName = "NotificationList",
				PluralName = "NotificationLists",
			};
        }

	}

    public partial class MetaTaskAssignment : MetaClass
	{
	    public static MetaTaskAssignment Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType User;
        public RoleType Notification;
        public RoleType Task;

		// Inherited Roles
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations
        public AssociationType TaskListWhereTaskAssignment;
        public AssociationType TaskListWhereOpenTaskAssignment;

		// Inherited Associations


		internal MetaTaskAssignment(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("4092d0b4-c6f4-4b81-b023-66be3f4c90bd"))
			{
				SingularName = "TaskAssignment",
				PluralName = "TaskAssignments",
			};
        }

	}

    public partial class MetaTaskList : MetaClass
	{
	    public static MetaTaskList Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;
        public MethodType Delete;

		// Defined Roles
        public RoleType TaskAssignments;
        public RoleType OpenTaskAssignments;
        public RoleType Count;

		// Inherited Roles

		// Defined Associations
        public AssociationType UserWhereTaskList;

		// Inherited Associations


		internal MetaTaskList(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("1c2303a1-f3ce-4084-a1ad-fc25156ac542"))
			{
				SingularName = "TaskList",
				PluralName = "TaskLists",
			};
        }

	}

    public partial class MetaUserGroup : MetaClass
	{
	    public static MetaUserGroup Instance { get; internal set;}

		public override Class Class { get; }

		// Defined Methods

		// Inherited Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Defined Roles
        public RoleType Members;
        public RoleType Name;

		// Inherited Roles
        public ConcreteRoleType UniqueId;
        public ConcreteRoleType DeniedPermissions;
        public ConcreteRoleType SecurityTokens;

		// Defined Associations
        public AssociationType AccessControlsWhereSubjectGroup;

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;


		internal MetaUserGroup(MetaPopulation metaPopulation)
        {
			this.Class = new Class(metaPopulation, new System.Guid("60065f5d-a3c2-4418-880d-1026ab607319"))
			{
				SingularName = "UserGroup",
				PluralName = "UserGroups",
			};
        }

	}
}