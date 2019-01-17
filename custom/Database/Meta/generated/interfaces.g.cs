namespace Allors.Meta
{
    public partial class MetaObject : MetaInterface
	{
	    public static MetaObject Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods
        public MethodType OnBuild;
        public MethodType OnPostBuild;
        public MethodType OnPreDerive;
        public MethodType OnDerive;
        public MethodType OnPostDerive;

		// Inherited Methods

		// Defined Roles

		// Inherited Roles

		// Defined Associations

		// Inherited Associations

		internal MetaObject(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("12504f04-02c6-4778-98fe-04eba12ef8b2"))
			{
				SingularName = "Object",
			};
        }
	}

    public partial class MetaCachable : MetaInterface
	{
	    public static MetaCachable Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType CacheId;

		// Inherited Roles

		// Defined Associations

		// Inherited Associations

		internal MetaCachable(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("B17AFC19-9E91-4631-B6D8-43B32A65E0A0"))
			{
				SingularName = "Cachable",
			};
        }
	}

    public partial class MetaDeletable : MetaInterface
	{
	    public static MetaDeletable Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods
        public MethodType Delete;

		// Inherited Methods

		// Defined Roles

		// Inherited Roles

		// Defined Associations

		// Inherited Associations

		internal MetaDeletable(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("9279e337-c658-4086-946d-03c75cdb1ad3"))
			{
				SingularName = "Deletable",
			};
        }
	}

    public partial class MetaEnumeration : MetaInterface
	{
	    public static MetaEnumeration Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType Name;
        public RoleType LocalisedNames;
        public RoleType IsActive;

		// Inherited Roles
        public RoleType DeniedPermissions;
        public RoleType SecurityTokens;
        public RoleType UniqueId;

		// Defined Associations

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;

		internal MetaEnumeration(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("b7bcc22f-03f0-46fd-b738-4e035921d445"))
			{
				SingularName = "Enumeration",
			};
        }
	}

    public partial class MetaUniquelyIdentifiable : MetaInterface
	{
	    public static MetaUniquelyIdentifiable Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType UniqueId;

		// Inherited Roles

		// Defined Associations
        public AssociationType NotificationsWhereTarget;

		// Inherited Associations

		internal MetaUniquelyIdentifiable(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("122ccfe1-f902-44c1-9d6c-6f6a0afa9469"))
			{
				SingularName = "UniquelyIdentifiable",
			};
        }
	}

    public partial class MetaVersion : MetaInterface
	{
	    public static MetaVersion Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType DerivationId;
        public RoleType DerivationTimeStamp;

		// Inherited Roles
        public RoleType DeniedPermissions;
        public RoleType SecurityTokens;

		// Defined Associations

		// Inherited Associations

		internal MetaVersion(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("A6A3C79E-150B-4586-96EA-5AC0E2E638C6"))
			{
				SingularName = "Version",
			};
        }
	}

    public partial class MetaVersioned : MetaInterface
	{
	    public static MetaVersioned Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles

		// Inherited Roles

		// Defined Associations

		// Inherited Associations

		internal MetaVersioned(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("39F9CB84-B321-424A-864C-0B128ACAA965"))
			{
				SingularName = "Versioned",
			};
        }
	}

    public partial class MetaLocalised : MetaInterface
	{
	    public static MetaLocalised Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType Locale;

		// Inherited Roles

		// Defined Associations

		// Inherited Associations

		internal MetaLocalised(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("7979a17c-0829-46df-a0d4-1b01775cfaac"))
			{
				SingularName = "Localised",
			};
        }
	}

    public partial class MetaAccessControlledObject : MetaInterface
	{
	    public static MetaAccessControlledObject Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType DeniedPermissions;
        public RoleType SecurityTokens;

		// Inherited Roles

		// Defined Associations

		// Inherited Associations

		internal MetaAccessControlledObject(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("eb0ff756-3e3d-4cf9-8935-8802a73d2df2"))
			{
				SingularName = "AccessControlledObject",
			};
        }
	}

    public partial class MetaDelegatedAccessControlledObject : MetaInterface
	{
	    public static MetaDelegatedAccessControlledObject Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods
        public MethodType DelegateAccess;

		// Inherited Methods

		// Defined Roles

		// Inherited Roles
        public RoleType DeniedPermissions;
        public RoleType SecurityTokens;

		// Defined Associations

		// Inherited Associations

		internal MetaDelegatedAccessControlledObject(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("842FA7B5-2668-43E9-BFEF-21B6F5B20E8B"))
			{
				SingularName = "DelegatedAccessControlledObject",
			};
        }
	}

    public partial class MetaSecurityTokenOwner : MetaInterface
	{
	    public static MetaSecurityTokenOwner Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType OwnerSecurityToken;
        public RoleType OwnerAccessControl;

		// Inherited Roles

		// Defined Associations

		// Inherited Associations

		internal MetaSecurityTokenOwner(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("a69cad9c-c2f1-463f-9af1-873ce65aeea6"))
			{
				SingularName = "SecurityTokenOwner",
			};
        }
	}

    public partial class MetaObjectState : MetaInterface
	{
	    public static MetaObjectState Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType DeniedPermissions;
        public RoleType Name;

		// Inherited Roles
        public RoleType UniqueId;

		// Defined Associations
        public AssociationType TransitionalsWherePreviousObjectState;
        public AssociationType TransitionalsWhereLastObjectState;
        public AssociationType TransitionalsWhereObjectState;
        public AssociationType TransitionalVersionsWherePreviousObjectState;
        public AssociationType TransitionalVersionsWhereLastObjectState;
        public AssociationType TransitionalVersionsWhereObjectState;

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;

		internal MetaObjectState(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("f991813f-3146-4431-96d0-554aa2186887"))
			{
				SingularName = "ObjectState",
			};
        }
	}

    public partial class MetaTask : MetaInterface
	{
	    public static MetaTask Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType WorkItem;
        public RoleType DateCreated;
        public RoleType DateClosed;
        public RoleType Participants;
        public RoleType Performer;

		// Inherited Roles
        public RoleType DeniedPermissions;
        public RoleType SecurityTokens;
        public RoleType UniqueId;

		// Defined Associations
        public AssociationType TaskAssignmentsWhereTask;

		// Inherited Associations
        public AssociationType NotificationsWhereTarget;

		internal MetaTask(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("84eb0e6e-68e1-478c-a35f-6036d45792be"))
			{
				SingularName = "Task",
			};
        }
	}

    public partial class MetaTransitional : MetaInterface
	{
	    public static MetaTransitional Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType PreviousObjectStates;
        public RoleType LastObjectStates;
        public RoleType ObjectStates;

		// Inherited Roles
        public RoleType DeniedPermissions;
        public RoleType SecurityTokens;

		// Defined Associations

		// Inherited Associations

		internal MetaTransitional(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("ab2179ad-9eac-4b61-8d84-81cd777c4926"))
			{
				SingularName = "Transitional",
			};
        }
	}

    public partial class MetaTransitionalVersion : MetaInterface
	{
	    public static MetaTransitionalVersion Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType PreviousObjectStates;
        public RoleType LastObjectStates;
        public RoleType ObjectStates;

		// Inherited Roles
        public RoleType DeniedPermissions;
        public RoleType SecurityTokens;

		// Defined Associations

		// Inherited Associations

		internal MetaTransitionalVersion(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("A13C9057-8786-40CA-8421-476E55787D73"))
			{
				SingularName = "TransitionalVersion",
			};
        }
	}

    public partial class MetaUser : MetaInterface
	{
	    public static MetaUser Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType UserName;
        public RoleType NormalizedUserName;
        public RoleType UserPasswordHash;
        public RoleType UserEmail;
        public RoleType UserEmailConfirmed;
        public RoleType TaskList;
        public RoleType NotificationList;

		// Inherited Roles
        public RoleType OwnerSecurityToken;
        public RoleType OwnerAccessControl;
        public RoleType DeniedPermissions;
        public RoleType SecurityTokens;

		// Defined Associations
        public AssociationType SingletonWhereGuest;
        public AssociationType AccessControlsWhereSubject;
        public AssociationType AccessControlsWhereEffectiveUser;
        public AssociationType LoginsWhereUser;
        public AssociationType EmailMessagesWhereSender;
        public AssociationType EmailMessagesWhereRecipient;
        public AssociationType TaskAssignmentsWhereUser;
        public AssociationType UserGroupsWhereMember;

		// Inherited Associations

		internal MetaUser(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("a0309c3b-6f80-4777-983e-6e69800df5be"))
			{
				SingularName = "User",
			};
        }
	}

    public partial class MetaWorkItem : MetaInterface
	{
	    public static MetaWorkItem Instance { get; internal set;}

		public override Interface Interface { get; }

		// Defined Methods

		// Inherited Methods

		// Defined Roles
        public RoleType WorkItemDescription;

		// Inherited Roles

		// Defined Associations
        public AssociationType TasksWhereWorkItem;

		// Inherited Associations

		internal MetaWorkItem(MetaPopulation metaPopulation)
        {
			this.Interface = new Interface(metaPopulation, new System.Guid("fbea29c6-6109-4163-a088-9f0b4deac896"))
			{
				SingularName = "WorkItem",
			};
        }
	}
}