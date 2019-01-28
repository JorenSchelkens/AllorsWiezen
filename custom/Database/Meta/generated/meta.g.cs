namespace Allors.Meta
{
	public static class M
	{
		// Interfaces
        public static readonly MetaObject Object;
        public static readonly MetaCachable Cachable;
        public static readonly MetaDeletable Deletable;
        public static readonly MetaEnumeration Enumeration;
        public static readonly MetaUniquelyIdentifiable UniquelyIdentifiable;
        public static readonly MetaVersion Version;
        public static readonly MetaVersioned Versioned;
        public static readonly MetaPrintable Printable;
        public static readonly MetaLocalised Localised;
        public static readonly MetaAccessControlledObject AccessControlledObject;
        public static readonly MetaDelegatedAccessControlledObject DelegatedAccessControlledObject;
        public static readonly MetaSecurityTokenOwner SecurityTokenOwner;
        public static readonly MetaObjectState ObjectState;
        public static readonly MetaTask Task;
        public static readonly MetaTransitional Transitional;
        public static readonly MetaTransitionalVersion TransitionalVersion;
        public static readonly MetaUser User;
        public static readonly MetaWorkItem WorkItem;

		// Classes
        public static readonly MetaEmployment Employment;
        public static readonly MetaOrganisation Organisation;
        public static readonly MetaPerson Person;
        public static readonly MetaSettings Settings;
        public static readonly MetaSingleton Singleton;
        public static readonly MetaCounter Counter;
        public static readonly MetaMedia Media;
        public static readonly MetaMediaContent MediaContent;
        public static readonly MetaPrintDocument PrintDocument;
        public static readonly MetaTemplate Template;
        public static readonly MetaTemplateType TemplateType;
        public static readonly MetaPreparedExtent PreparedExtent;
        public static readonly MetaPreparedFetch PreparedFetch;
        public static readonly MetaCountry Country;
        public static readonly MetaCurrency Currency;
        public static readonly MetaLanguage Language;
        public static readonly MetaLocale Locale;
        public static readonly MetaLocalisedText LocalisedText;
        public static readonly MetaAccessControl AccessControl;
        public static readonly MetaLogin Login;
        public static readonly MetaPermission Permission;
        public static readonly MetaRole Role;
        public static readonly MetaSecurityToken SecurityToken;
        public static readonly MetaAutomatedAgent AutomatedAgent;
        public static readonly MetaEmailMessage EmailMessage;
        public static readonly MetaNotification Notification;
        public static readonly MetaNotificationList NotificationList;
        public static readonly MetaTaskAssignment TaskAssignment;
        public static readonly MetaTaskList TaskList;
        public static readonly MetaUserGroup UserGroup;


		static M()
		{
		    // Interfaces
            Object = MetaObject.Instance;
            Cachable = MetaCachable.Instance;
            Deletable = MetaDeletable.Instance;
            Enumeration = MetaEnumeration.Instance;
            UniquelyIdentifiable = MetaUniquelyIdentifiable.Instance;
            Version = MetaVersion.Instance;
            Versioned = MetaVersioned.Instance;
            Printable = MetaPrintable.Instance;
            Localised = MetaLocalised.Instance;
            AccessControlledObject = MetaAccessControlledObject.Instance;
            DelegatedAccessControlledObject = MetaDelegatedAccessControlledObject.Instance;
            SecurityTokenOwner = MetaSecurityTokenOwner.Instance;
            ObjectState = MetaObjectState.Instance;
            Task = MetaTask.Instance;
            Transitional = MetaTransitional.Instance;
            TransitionalVersion = MetaTransitionalVersion.Instance;
            User = MetaUser.Instance;
            WorkItem = MetaWorkItem.Instance;

		    // Classes
            Employment = MetaEmployment.Instance;
            Organisation = MetaOrganisation.Instance;
            Person = MetaPerson.Instance;
            Settings = MetaSettings.Instance;
            Singleton = MetaSingleton.Instance;
            Counter = MetaCounter.Instance;
            Media = MetaMedia.Instance;
            MediaContent = MetaMediaContent.Instance;
            PrintDocument = MetaPrintDocument.Instance;
            Template = MetaTemplate.Instance;
            TemplateType = MetaTemplateType.Instance;
            PreparedExtent = MetaPreparedExtent.Instance;
            PreparedFetch = MetaPreparedFetch.Instance;
            Country = MetaCountry.Instance;
            Currency = MetaCurrency.Instance;
            Language = MetaLanguage.Instance;
            Locale = MetaLocale.Instance;
            LocalisedText = MetaLocalisedText.Instance;
            AccessControl = MetaAccessControl.Instance;
            Login = MetaLogin.Instance;
            Permission = MetaPermission.Instance;
            Role = MetaRole.Instance;
            SecurityToken = MetaSecurityToken.Instance;
            AutomatedAgent = MetaAutomatedAgent.Instance;
            EmailMessage = MetaEmailMessage.Instance;
            Notification = MetaNotification.Instance;
            NotificationList = MetaNotificationList.Instance;
            TaskAssignment = MetaTaskAssignment.Instance;
            TaskList = MetaTaskList.Instance;
            UserGroup = MetaUserGroup.Instance;
		}
	}

	public partial class MetaInterface 
	{
		public void Extend()
		{
			this.BaseExtend();
			this.CoreExtend();
			this.CustomExtend();
		}

       internal virtual void BaseExtend() {}
       internal virtual void CoreExtend() {}
       internal virtual void CustomExtend() {}
	}

	public partial class MetaClass 
	{
		public void Extend()
		{
			this.BaseExtend();
			this.CoreExtend();
			this.CustomExtend();
		}

       internal virtual void BaseExtend() {}
       internal virtual void CoreExtend() {}
       internal virtual void CustomExtend() {}
	}
}