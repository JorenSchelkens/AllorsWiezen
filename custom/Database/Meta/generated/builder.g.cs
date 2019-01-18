namespace Allors.Meta
{
	internal class MetaBuilder
	{
	    private readonly MetaPopulation metaPopulation;

        internal MetaBuilder(MetaPopulation metaPopulation)
		{
			this.metaPopulation = metaPopulation;
		}

		internal void BuildDomains()
		{
            MetaCustom.Instance = new MetaCustom(this.metaPopulation);
            MetaCore.Instance = new MetaCore(this.metaPopulation);
            MetaBase.Instance = new MetaBase(this.metaPopulation);
		}

		internal void BuildDomainInheritances()
		{
			MetaCustom.Instance.Domain.AddDirectSuperdomain(MetaBase.Instance.Domain);



			MetaBase.Instance.Domain.AddDirectSuperdomain(MetaCore.Instance.Domain);

		}

		internal void BuildUnits()
		{
            MetaBinary.Instance = new MetaBinary(this.metaPopulation);
            MetaBoolean.Instance = new MetaBoolean(this.metaPopulation);
            MetaDateTime.Instance = new MetaDateTime(this.metaPopulation);
            MetaDecimal.Instance = new MetaDecimal(this.metaPopulation);
            MetaFloat.Instance = new MetaFloat(this.metaPopulation);
            MetaInteger.Instance = new MetaInteger(this.metaPopulation);
            MetaString.Instance = new MetaString(this.metaPopulation);
            MetaUnique.Instance = new MetaUnique(this.metaPopulation);
		}

		internal void BuildInterfaces()
		{
            MetaObject.Instance = new MetaObject(this.metaPopulation);
            MetaCachable.Instance = new MetaCachable(this.metaPopulation);
            MetaDeletable.Instance = new MetaDeletable(this.metaPopulation);
            MetaEnumeration.Instance = new MetaEnumeration(this.metaPopulation);
            MetaUniquelyIdentifiable.Instance = new MetaUniquelyIdentifiable(this.metaPopulation);
            MetaVersion.Instance = new MetaVersion(this.metaPopulation);
            MetaVersioned.Instance = new MetaVersioned(this.metaPopulation);
            MetaLocalised.Instance = new MetaLocalised(this.metaPopulation);
            MetaAccessControlledObject.Instance = new MetaAccessControlledObject(this.metaPopulation);
            MetaDelegatedAccessControlledObject.Instance = new MetaDelegatedAccessControlledObject(this.metaPopulation);
            MetaSecurityTokenOwner.Instance = new MetaSecurityTokenOwner(this.metaPopulation);
            MetaObjectState.Instance = new MetaObjectState(this.metaPopulation);
            MetaTask.Instance = new MetaTask(this.metaPopulation);
            MetaTransitional.Instance = new MetaTransitional(this.metaPopulation);
            MetaTransitionalVersion.Instance = new MetaTransitionalVersion(this.metaPopulation);
            MetaUser.Instance = new MetaUser(this.metaPopulation);
            MetaWorkItem.Instance = new MetaWorkItem(this.metaPopulation);
		}

		internal void BuildClasses()
		{
            MetaEmployment.Instance = new MetaEmployment(this.metaPopulation);
            MetaOrganisation.Instance = new MetaOrganisation(this.metaPopulation);
            MetaPerson.Instance = new MetaPerson(this.metaPopulation);
            MetaSettings.Instance = new MetaSettings(this.metaPopulation);
            MetaSingleton.Instance = new MetaSingleton(this.metaPopulation);
            MetaCounter.Instance = new MetaCounter(this.metaPopulation);
            MetaMedia.Instance = new MetaMedia(this.metaPopulation);
            MetaMediaContent.Instance = new MetaMediaContent(this.metaPopulation);
            MetaTemplate.Instance = new MetaTemplate(this.metaPopulation);
            MetaTemplateType.Instance = new MetaTemplateType(this.metaPopulation);
            MetaPreparedExtent.Instance = new MetaPreparedExtent(this.metaPopulation);
            MetaPreparedFetch.Instance = new MetaPreparedFetch(this.metaPopulation);
            MetaCountry.Instance = new MetaCountry(this.metaPopulation);
            MetaCurrency.Instance = new MetaCurrency(this.metaPopulation);
            MetaLanguage.Instance = new MetaLanguage(this.metaPopulation);
            MetaLocale.Instance = new MetaLocale(this.metaPopulation);
            MetaLocalisedText.Instance = new MetaLocalisedText(this.metaPopulation);
            MetaAccessControl.Instance = new MetaAccessControl(this.metaPopulation);
            MetaLogin.Instance = new MetaLogin(this.metaPopulation);
            MetaPermission.Instance = new MetaPermission(this.metaPopulation);
            MetaRole.Instance = new MetaRole(this.metaPopulation);
            MetaSecurityToken.Instance = new MetaSecurityToken(this.metaPopulation);
            MetaAutomatedAgent.Instance = new MetaAutomatedAgent(this.metaPopulation);
            MetaEmailMessage.Instance = new MetaEmailMessage(this.metaPopulation);
            MetaNotification.Instance = new MetaNotification(this.metaPopulation);
            MetaNotificationList.Instance = new MetaNotificationList(this.metaPopulation);
            MetaTaskAssignment.Instance = new MetaTaskAssignment(this.metaPopulation);
            MetaTaskList.Instance = new MetaTaskList(this.metaPopulation);
            MetaUserGroup.Instance = new MetaUserGroup(this.metaPopulation);
		}

		internal void BuildInheritances()
		{
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaEmployment.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaEmployment.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaOrganisation.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaOrganisation.Instance.ObjectType, Supertype = MetaLocalised.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaOrganisation.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaPerson.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaPerson.Instance.ObjectType, Supertype = MetaUser.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaPerson.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaSettings.Instance.ObjectType, Supertype = MetaObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaSingleton.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaCounter.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaMedia.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaMedia.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaMedia.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaMediaContent.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaMediaContent.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTemplate.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTemplate.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTemplate.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTemplateType.Instance.ObjectType, Supertype = MetaEnumeration.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTemplateType.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaPreparedExtent.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaPreparedExtent.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaPreparedFetch.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaPreparedFetch.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaCountry.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaCurrency.Instance.ObjectType, Supertype = MetaEnumeration.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaLanguage.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaLocale.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaLocalisedText.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaLocalisedText.Instance.ObjectType, Supertype = MetaLocalised.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaLocalisedText.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaAccessControl.Instance.ObjectType, Supertype = MetaCachable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaAccessControl.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaAccessControl.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaLogin.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaPermission.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaPermission.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaRole.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaRole.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaSecurityToken.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaAutomatedAgent.Instance.ObjectType, Supertype = MetaUser.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaEmailMessage.Instance.ObjectType, Supertype = MetaObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaNotification.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaNotificationList.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaNotificationList.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTaskAssignment.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTaskAssignment.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTaskList.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaUserGroup.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaUserGroup.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};

            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaCachable.Instance.ObjectType, Supertype = MetaObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaDeletable.Instance.ObjectType, Supertype = MetaObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaEnumeration.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaEnumeration.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaUniquelyIdentifiable.Instance.ObjectType, Supertype = MetaObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaVersion.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaVersioned.Instance.ObjectType, Supertype = MetaObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaLocalised.Instance.ObjectType, Supertype = MetaObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaAccessControlledObject.Instance.ObjectType, Supertype = MetaObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaDelegatedAccessControlledObject.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaSecurityTokenOwner.Instance.ObjectType, Supertype = MetaObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaObjectState.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTask.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTask.Instance.ObjectType, Supertype = MetaUniquelyIdentifiable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTask.Instance.ObjectType, Supertype = MetaDeletable.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTransitional.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaTransitionalVersion.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaUser.Instance.ObjectType, Supertype = MetaSecurityTokenOwner.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaUser.Instance.ObjectType, Supertype = MetaAccessControlledObject.Instance.Interface};
            new Inheritance(this.metaPopulation){ Subtype = (Composite)MetaWorkItem.Instance.ObjectType, Supertype = MetaObject.Instance.Interface};
		}

		internal void BuildRoles()
		{
			BuildRolesEmployment();
			BuildRolesOrganisation();
			BuildRolesPerson();
			BuildRolesSettings();
			BuildRolesSingleton();
			BuildRolesCounter();
			BuildRolesMedia();
			BuildRolesMediaContent();
			BuildRolesTemplate();
			BuildRolesTemplateType();
			BuildRolesPreparedExtent();
			BuildRolesPreparedFetch();
			BuildRolesCountry();
			BuildRolesCurrency();
			BuildRolesLanguage();
			BuildRolesLocale();
			BuildRolesLocalisedText();
			BuildRolesAccessControl();
			BuildRolesLogin();
			BuildRolesPermission();
			BuildRolesRole();
			BuildRolesSecurityToken();
			BuildRolesAutomatedAgent();
			BuildRolesEmailMessage();
			BuildRolesNotification();
			BuildRolesNotificationList();
			BuildRolesTaskAssignment();
			BuildRolesTaskList();
			BuildRolesUserGroup();
			BuildRolesObject();
			BuildRolesCachable();
			BuildRolesDeletable();
			BuildRolesEnumeration();
			BuildRolesUniquelyIdentifiable();
			BuildRolesVersion();
			BuildRolesVersioned();
			BuildRolesLocalised();
			BuildRolesAccessControlledObject();
			BuildRolesDelegatedAccessControlledObject();
			BuildRolesSecurityTokenOwner();
			BuildRolesObjectState();
			BuildRolesTask();
			BuildRolesTransitional();
			BuildRolesTransitionalVersion();
			BuildRolesUser();
			BuildRolesWorkItem();
		}

	private void BuildRolesEmployment() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("12AC77FF-5E0B-4E72-B9AE-8375CDD840DE"), new System.Guid("BCFC78B7-0075-4270-BB0F-C19AA398CE18"), new System.Guid("8A7B367C-C0CD-4E8B-B169-4F9A400FC30E"));
		relationType.AssociationType.ObjectType = MetaEmployment.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaOrganisation.Instance;
		relationType.RoleType.SingularName = "Employer";
		relationType.RoleType.PluralName = "Employers";
		relationType.RoleType.IsRequired = true;
		MetaEmployment.Instance.Employer = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("35B8F4AD-E291-4ADB-B311-980BB1685BFD"), new System.Guid("25270F26-6F40-4D6D-AACD-BBC7D56DFD56"), new System.Guid("9BA61F25-3547-4364-8C20-A7A68A05EC37"));
		relationType.AssociationType.ObjectType = MetaEmployment.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaPerson.Instance;
		relationType.RoleType.SingularName = "Employee";
		relationType.RoleType.PluralName = "Employees";
		relationType.RoleType.IsRequired = true;
		MetaEmployment.Instance.Employee = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("28BD57B7-9653-45E0-A2BB-EE53A4F3642C"), new System.Guid("5A2EB977-C8AA-4723-A8F6-B048C54556C7"), new System.Guid("5937A273-AC8A-43C1-8E8D-51035C351B69"));
		relationType.AssociationType.ObjectType = MetaEmployment.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaDateTime.Instance;
		relationType.RoleType.SingularName = "From";
		relationType.RoleType.PluralName = "Froms";
		relationType.RoleType.IsRequired = true;
		MetaEmployment.Instance.From = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("A1495CB5-47D5-4D60-97F4-380BE9120865"), new System.Guid("E1423D7E-623A-4D68-B5B9-9E95A0EA5118"), new System.Guid("8832FE15-CC92-42EA-B15C-DFFB6E228193"));
		relationType.AssociationType.ObjectType = MetaEmployment.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaDateTime.Instance;
		relationType.RoleType.SingularName = "Through";
		relationType.RoleType.PluralName = "Throughs";
		MetaEmployment.Instance.Through = relationType.RoleType; 
	}
	}


	private void BuildRolesOrganisation() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("2cc74901-cda5-4185-bcd8-d51c745a8437"), new System.Guid("896a4589-4caf-4cd2-8365-c4200b12f519"), new System.Guid("baa30557-79ff-406d-b374-9d32519b2de7"));
		relationType.AssociationType.ObjectType = MetaOrganisation.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.Size = 256;
		MetaOrganisation.Instance.Name = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("FEEA239C-D356-4732-9C7B-DCAC1BD9A237"), new System.Guid("708D8F20-2CB9-4A39-A476-E8920AFAC6F7"), new System.Guid("5EFC6B5F-2850-49E8-814A-E29AE567E69B"));
		relationType.AssociationType.ObjectType = MetaOrganisation.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaPerson.Instance;
		relationType.RoleType.SingularName = "CurrentEmployee";
		relationType.RoleType.PluralName = "CurrentEmployees";
		MetaOrganisation.Instance.CurrentEmployees = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("A56B4D52-90CB-4A21-B7C1-58F0F7132D13"), new System.Guid("E2200A6C-B561-4579-A6A9-824FE079A973"), new System.Guid("8813DE45-D779-4E82-816E-C86CFC617CEE"));
		relationType.AssociationType.ObjectType = MetaOrganisation.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaPerson.Instance;
		relationType.RoleType.SingularName = "FormerEmployee";
		relationType.RoleType.PluralName = "FormerEmployees";
		MetaOrganisation.Instance.FormerEmployees = relationType.RoleType; 
	}
	}


	private void BuildRolesPerson() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("f92c5c86-c32a-41e0-99ff-2d94a8d6ccfa"), new System.Guid("0ff499d5-300f-483c-b722-757787c1f4b3"), new System.Guid("2162765c-5fd8-42aa-85f7-20f0effbc308"));
		relationType.AssociationType.ObjectType = MetaPerson.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaMedia.Instance;
		relationType.RoleType.SingularName = "Picture";
		relationType.RoleType.PluralName = "Pictures";
		MetaPerson.Instance.Picture = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("ed4b710a-fe24-4143-bb96-ed1bd9beae1a"), new System.Guid("1ea9eca4-eed0-4f61-8903-c99feae961ad"), new System.Guid("f10ea049-6d24-4ca2-8efa-032fcf3000b3"));
		relationType.AssociationType.ObjectType = MetaPerson.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "FirstName";
		relationType.RoleType.PluralName = "FirstNames";
		relationType.RoleType.Size = 256;
		MetaPerson.Instance.FirstName = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("8a3e4664-bb40-4208-8e90-a1b5be323f27"), new System.Guid("9b48ff56-afef-4501-ac97-6173731ff2c9"), new System.Guid("ace04ad8-bf64-4fc3-8216-14a720d3105d"));
		relationType.AssociationType.ObjectType = MetaPerson.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "LastName";
		relationType.RoleType.PluralName = "LastNames";
		relationType.RoleType.Size = 256;
		MetaPerson.Instance.LastName = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("eb18bb28-da9c-47b4-a091-2f8f2303dcb6"), new System.Guid("e3a4d7b2-c5f1-4101-9aab-a0135d37a5a5"), new System.Guid("a86fc7a6-dedd-4da9-a250-75c9ec730d22"));
		relationType.AssociationType.ObjectType = MetaPerson.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "MiddleName";
		relationType.RoleType.PluralName = "MiddleNames";
		relationType.RoleType.Size = 256;
		MetaPerson.Instance.MiddleName = relationType.RoleType; 
	}
	}


	private void BuildRolesSettings() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("1A3BFB5A-10AE-4B95-B592-673D17B69018"), new System.Guid("03A8792D-7D7C-48D8-A9D4-85C20663CE5B"), new System.Guid("0ABD5CA7-ABC4-4EC3-A148-F9BB1857DC70"));
		relationType.AssociationType.ObjectType = MetaSettings.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaCounter.Instance;
		relationType.RoleType.SingularName = "Counter";
		relationType.RoleType.PluralName = "Counters";
		MetaSettings.Instance.Counter = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("A74F8F8B-90C7-4A50-A3EB-A12449AA1066"), new System.Guid("B44031D6-E75A-4EDB-B683-ACAC7578749E"), new System.Guid("C3376114-B34C-4F18-8C50-041F767B439E"));
		relationType.AssociationType.ObjectType = MetaSettings.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Setting";
		relationType.RoleType.PluralName = "Settings";
		MetaSettings.Instance.Setting = relationType.RoleType; 
	}
	}


	private void BuildRolesSingleton() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("d9ea02e5-9aa1-4cbe-9318-06324529a923"), new System.Guid("6247e69d-4789-4ee0-a75b-c2de44a5fcce"), new System.Guid("c11f31e1-75a7-4b23-9d58-7dfec256b658"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaSecurityToken.Instance;
		relationType.RoleType.SingularName = "AdministratorSecurityToken";
		relationType.RoleType.PluralName = "AdministratorSecurityTokens";
		MetaSingleton.Instance.AdministratorSecurityToken = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("D53B80EE-468D-463C-8BBF-725105DBA376"), new System.Guid("18C9321B-0846-401D-825F-16BAAE18708D"), new System.Guid("4541B748-349F-4BEF-86F2-3644423FE0AB"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaSettings.Instance;
		relationType.RoleType.SingularName = "Settings";
		relationType.RoleType.PluralName = "Settings";
		MetaSingleton.Instance.Settings = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("9c1634ab-be99-4504-8690-ed4b39fec5bc"), new System.Guid("45a4205d-7c02-40d4-8d97-6d7d59e05def"), new System.Guid("1e051b37-cf30-43ed-a623-dd2928d6d0a3"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaLocale.Instance;
		relationType.RoleType.SingularName = "DefaultLocale";
		relationType.RoleType.PluralName = "DefaultLocales";
		MetaSingleton.Instance.DefaultLocale = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("9e5a3413-ed33-474f-adf2-149ad5a80719"), new System.Guid("33d5d8b9-3472-48d8-ab1a-83d00d9cb691"), new System.Guid("e75a8956-4d02-49ba-b0cf-747b7a9f350d"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaLocale.Instance;
		relationType.RoleType.SingularName = "AdditionalLocale";
		relationType.RoleType.PluralName = "AdditionalLocales";
		MetaSingleton.Instance.AdditionalLocales = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("f16652b0-b712-43d7-8d4e-34a22487514d"), new System.Guid("c92466b5-55ba-496a-8880-2821f32f8f8e"), new System.Guid("3a12d798-40c3-40e0-ba9f-9d01b1e39e89"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUser.Instance;
		relationType.RoleType.SingularName = "Guest";
		relationType.RoleType.PluralName = "Guests";
		MetaSingleton.Instance.Guest = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("6A6E0852-C984-47B8-939D-8E0B0B042B9D"), new System.Guid("E783AFBE-EF70-4AC1-8C0A-5DFE6FEDFBE0"), new System.Guid("BCF431F6-10CD-4F33-873D-0B2F1A1EA09D"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaSecurityToken.Instance;
		relationType.RoleType.SingularName = "InitialSecurityToken";
		relationType.RoleType.PluralName = "InitialSecurityTokens";
		MetaSingleton.Instance.InitialSecurityToken = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("f579494b-e550-4be6-9d93-84618ac78704"), new System.Guid("33f17e75-99cc-417e-99f3-c29080f08f0a"), new System.Guid("ca9e3469-583c-4950-ba2c-1bc3a0fc3e96"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaSecurityToken.Instance;
		relationType.RoleType.SingularName = "DefaultSecurityToken";
		relationType.RoleType.PluralName = "DefaultSecurityTokens";
		MetaSingleton.Instance.DefaultSecurityToken = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("4D17A849-9AC9-4A5D-9F2A-EA0152061A15"), new System.Guid("6854E369-3026-47B1-AF0C-142A5C6FCA8E"), new System.Guid("2C8B5D6D-0AF1-479D-B916-29F080856BD6"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaAccessControl.Instance;
		relationType.RoleType.SingularName = "CreatorsAccessControl";
		relationType.RoleType.PluralName = "CreatorsAccessControls";
		MetaSingleton.Instance.CreatorsAccessControl = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("f7e50cac-ab57-4ebe-b765-d63804924c48"), new System.Guid("cb47a309-ed8f-47d1-879f-478e63b350d8"), new System.Guid("c955b6ef-57b7-404f-bba5-fa7aebf706f6"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaAccessControl.Instance;
		relationType.RoleType.SingularName = "GuestAccessControl";
		relationType.RoleType.PluralName = "GuestAccessControls";
		MetaSingleton.Instance.GuestAccessControl = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("829aa4a4-8232-4625-8cab-db7dc96da53f"), new System.Guid("56f18f8b-380b-4236-9a85-ed989c1a6e44"), new System.Guid("a3b765ed-bbf6-4bc4-9551-6338705ef03e"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaAccessControl.Instance;
		relationType.RoleType.SingularName = "AdministratorsAccessControl";
		relationType.RoleType.PluralName = "AdministratorsAccessControls";
		MetaSingleton.Instance.AdministratorsAccessControl = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("B2166062-84DA-449D-B34F-983A0C81BC31"), new System.Guid("22096B27-ED3C-4640-BB60-EB7338A779FB"), new System.Guid("1E931D15-5137-4C6D-91ED-9CC5C3C95BEF"));
		relationType.AssociationType.ObjectType = MetaSingleton.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaMedia.Instance;
		relationType.RoleType.SingularName = "LogoImage";
		relationType.RoleType.PluralName = "LogoImages";
		MetaSingleton.Instance.LogoImage = relationType.RoleType; 
	}
	}


	private void BuildRolesCounter() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("309d07d9-8dea-4e99-a3b8-53c0d360bc54"), new System.Guid("0c807020-5397-4cdb-8380-52899b7af6b7"), new System.Guid("ab60f6a7-d913-4377-ab47-97f0fb9d8f3b"));
		relationType.AssociationType.ObjectType = MetaCounter.Instance;
		relationType.RoleType.ObjectType = MetaInteger.Instance;
		relationType.RoleType.SingularName = "Value";
		relationType.RoleType.PluralName = "Values";
		relationType.RoleType.IsRequired = true;
		MetaCounter.Instance.Value = relationType.RoleType; 
	}
	}


	private void BuildRolesMedia() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("B74C2159-739A-4F1C-ADA7-C2DCC3CDCF83"), new System.Guid("96B21673-F124-4C30-A2F0-DF56D29E03F5"), new System.Guid("DE0FE224-C40D-469C-BDC5-849A7412EFEC"));
		relationType.AssociationType.ObjectType = MetaMedia.Instance;
		relationType.Workspace = true;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUnique.Instance;
		relationType.RoleType.SingularName = "Revision";
		relationType.RoleType.PluralName = "Revisions";
		MetaMedia.Instance.Revision = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("67082a51-1502-490b-b8db-537799e550bd"), new System.Guid("e8537dcf-1bd7-46c4-a37c-077bee6a78a1"), new System.Guid("02fe1ce8-c019-4a40-bd6f-b38d2f47a288"));
		relationType.AssociationType.ObjectType = MetaMedia.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaMediaContent.Instance;
		relationType.RoleType.SingularName = "MediaContent";
		relationType.RoleType.PluralName = "MediaContents";
		relationType.RoleType.IsRequired = true;
		MetaMedia.Instance.MediaContent = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("18236718-1835-430C-A936-7EC461EEE2CF"), new System.Guid("8A79E6C5-4BAE-468D-B57C-C7788D3E21E3"), new System.Guid("877ABDC8-8915-4640-8871-8CEF7EF69072"));
		relationType.AssociationType.ObjectType = MetaMedia.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaBinary.Instance;
		relationType.RoleType.SingularName = "InData";
		relationType.RoleType.PluralName = "InDatas";
		relationType.RoleType.Size = -1;
		MetaMedia.Instance.InData = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("79B04065-F13B-43B3-B86E-F3ADBBAAF0C4"), new System.Guid("287B7291-39F0-43E5-8770-811940E81BAE"), new System.Guid("CE17BFC7-5A4E-415A-9AE0-FAE429CEE69C"));
		relationType.AssociationType.ObjectType = MetaMedia.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "InDataUri";
		relationType.RoleType.PluralName = "InDataUris";
		relationType.RoleType.Size = -1;
		MetaMedia.Instance.InDataUri = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("DDD6C005-0104-44CA-A19C-1150B8BEB4A3"), new System.Guid("4F43B520-404E-436D-A514-71E4AEC55EC8"), new System.Guid("4C4EC21C-A3C0-4720-92E0-CF6532000265"));
		relationType.AssociationType.ObjectType = MetaMedia.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "FileName";
		relationType.RoleType.PluralName = "FileNames";
		relationType.RoleType.Size = 256;
		MetaMedia.Instance.FileName = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("29541613-0B16-49AD-8F40-3309A7C7D7B8"), new System.Guid("EFB76140-4A2A-4E7F-B51D-C95BCA774664"), new System.Guid("7CFC8B40-5199-4457-BBBD-27A786721465"));
		relationType.AssociationType.ObjectType = MetaMedia.Instance;
		relationType.Workspace = true;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Type";
		relationType.RoleType.PluralName = "Types";
		relationType.RoleType.Size = 1024;
		MetaMedia.Instance.Type = relationType.RoleType; 
	}
	}


	private void BuildRolesMediaContent() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("890598a9-0be4-49ee-8dd8-3581ee9355e6"), new System.Guid("3cf7f10e-dc56-4a50-95a5-fe7fae0be291"), new System.Guid("70823e7d-5829-4db7-99e0-f6c5f2b0e87b"));
		relationType.AssociationType.ObjectType = MetaMediaContent.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Type";
		relationType.RoleType.PluralName = "Types";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.Size = 1024;
		MetaMediaContent.Instance.Type = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("0756d508-44b7-405e-bf92-bc09e5702e63"), new System.Guid("76e6547b-8dcf-4e69-ae2d-c8f8c33989e9"), new System.Guid("85170945-b020-485b-bb6f-c4122992ebfd"));
		relationType.AssociationType.ObjectType = MetaMediaContent.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaBinary.Instance;
		relationType.RoleType.SingularName = "Data";
		relationType.RoleType.PluralName = "Datas";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.Size = -1;
		MetaMediaContent.Instance.Data = relationType.RoleType; 
	}
	}


	private void BuildRolesTemplate() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("64DD490F-2B13-4D63-94A4-6BCE96FA14C2"), new System.Guid("6A7D9713-92F1-41D6-B082-FD30FB247AA0"), new System.Guid("ADE2850A-0F0E-410F-B756-81F4928B703B"));
		relationType.AssociationType.ObjectType = MetaTemplate.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaTemplateType.Instance;
		relationType.RoleType.SingularName = "TemplateType";
		relationType.RoleType.PluralName = "TemplateTypes";
		relationType.RoleType.IsRequired = true;
		MetaTemplate.Instance.TemplateType = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("93C9C5F2-7D0B-475D-80B8-7CAC7B11CCDA"), new System.Guid("E5E4E397-E9D6-4E21-87D5-0A6BEF0431E4"), new System.Guid("A915962A-91B2-4EC0-A17D-1FA32AA239E1"));
		relationType.AssociationType.ObjectType = MetaTemplate.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaMedia.Instance;
		relationType.RoleType.SingularName = "Media";
		relationType.RoleType.PluralName = "Medias";
		relationType.RoleType.IsRequired = true;
		MetaTemplate.Instance.Media = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("3BC9EEAE-717F-4030-88ED-68057B14ACEC"), new System.Guid("8B04F22C-48EC-469F-BBD0-1136AF8325A3"), new System.Guid("786036A9-D4F7-449E-BC23-85D512CC53D3"));
		relationType.AssociationType.ObjectType = MetaTemplate.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Arguments";
		relationType.RoleType.PluralName = "Arguments";
		relationType.RoleType.IsRequired = true;
		MetaTemplate.Instance.Arguments = relationType.RoleType; 
	}
	}


	private void BuildRolesTemplateType() {

	}


	private void BuildRolesPreparedExtent() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("CEADE44E-AA67-4E77-83FC-2C6E141A89F6"), new System.Guid("A0D69E1C-AC7A-4D20-91A7-0D8EB9422CFC"), new System.Guid("A0CA7D9E-C05A-4B50-8EEA-53407BF78A3C"));
		relationType.AssociationType.ObjectType = MetaPreparedExtent.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.Size = 256;
		MetaPreparedExtent.Instance.Name = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("03B7FB15-970F-453D-B6AC-A50654775E5E"), new System.Guid("9652ADA4-CCCC-471E-8A8E-FAF9D6596CDD"), new System.Guid("55409DA7-AA4D-4132-A736-3D910F769129"));
		relationType.AssociationType.ObjectType = MetaPreparedExtent.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Description";
		relationType.RoleType.PluralName = "Descriptions";
		relationType.RoleType.Size = -1;
		MetaPreparedExtent.Instance.Description = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("712367B5-85ED-4623-9AC9-C082A32D8889"), new System.Guid("18852DD1-0F3F-4147-9298-6D5D47578CDA"), new System.Guid("04AD0310-A894-4BCC-B30E-E7B80C6861BA"));
		relationType.AssociationType.ObjectType = MetaPreparedExtent.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Content";
		relationType.RoleType.PluralName = "Contents";
		relationType.RoleType.Size = -1;
		MetaPreparedExtent.Instance.Content = relationType.RoleType; 
	}
	}


	private void BuildRolesPreparedFetch() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("A8CFE3FC-EC2E-4407-B3C5-681603AA2B67"), new System.Guid("7B64288F-DF7F-4553-AB9E-552A118A0886"), new System.Guid("292C9040-7F35-4A4B-86CE-5D79133CC5C6"));
		relationType.AssociationType.ObjectType = MetaPreparedFetch.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.Size = 256;
		MetaPreparedFetch.Instance.Name = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("B5A89EE5-960F-4ABC-A43D-19438264E019"), new System.Guid("20E9768B-76B5-47B5-95B3-556C4E0E9EF2"), new System.Guid("D05D37C2-5109-4C3B-BAF0-42BB7A10FB40"));
		relationType.AssociationType.ObjectType = MetaPreparedFetch.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Description";
		relationType.RoleType.PluralName = "Descriptions";
		relationType.RoleType.Size = -1;
		MetaPreparedFetch.Instance.Description = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("B26239E3-FA65-43F1-AAFF-0058DCCB462A"), new System.Guid("CF0621C6-1445-4B9E-A1D5-C859BCA09836"), new System.Guid("D49131D7-6111-4455-B96D-1D5609995172"));
		relationType.AssociationType.ObjectType = MetaPreparedFetch.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Content";
		relationType.RoleType.PluralName = "Contents";
		relationType.RoleType.Size = -1;
		MetaPreparedFetch.Instance.Content = relationType.RoleType; 
	}
	}


	private void BuildRolesCountry() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("62009cef-7424-4ec0-8953-e92b3cd6639d"), new System.Guid("323173ee-385c-4f74-8b78-ff05735460f8"), new System.Guid("4ca5a640-5d9e-4910-95ed-6872c7ea13d2"));
		relationType.AssociationType.ObjectType = MetaCountry.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaCurrency.Instance;
		relationType.RoleType.SingularName = "Currency";
		relationType.RoleType.PluralName = "Currencies";
		MetaCountry.Instance.Currency = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("f93acc4e-f89e-4610-ada9-e58f21c165bc"), new System.Guid("ea0efe67-89f2-4317-97e7-f0e14358e718"), new System.Guid("4fe997d6-d221-432b-9f09-4f77735c109b"));
		relationType.AssociationType.ObjectType = MetaCountry.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "IsoCode";
		relationType.RoleType.PluralName = "IsoCodes";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.IsUnique = true;
		relationType.RoleType.Size = 2;
		MetaCountry.Instance.IsoCode = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("6b9c977f-b394-440e-9781-5d56733b60da"), new System.Guid("6e3532ae-3528-4114-9274-54fc08effd0d"), new System.Guid("60f1f9a3-13d1-485f-bc77-fda1f9ef1815"));
		relationType.AssociationType.ObjectType = MetaCountry.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.IsUnique = true;
		relationType.RoleType.Size = 256;
		MetaCountry.Instance.Name = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("8236a702-a76d-4bb5-9afd-acacb1508261"), new System.Guid("9b682612-50f9-43f3-abde-4d0cb5156f0d"), new System.Guid("99c52c13-ef50-4f68-a32f-fef660aa3044"));
		relationType.AssociationType.ObjectType = MetaCountry.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaLocalisedText.Instance;
		relationType.RoleType.SingularName = "LocalisedName";
		relationType.RoleType.PluralName = "LocalisedNames";
		MetaCountry.Instance.LocalisedNames = relationType.RoleType; 
	}
	}


	private void BuildRolesCurrency() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("294a4bdc-f03a-47a2-a649-419e6b9021a3"), new System.Guid("f9eec7c6-c4cd-4d8c-a5f7-44855328cd7e"), new System.Guid("09d74027-4457-4788-803c-24b857245565"));
		relationType.AssociationType.ObjectType = MetaCurrency.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "IsoCode";
		relationType.RoleType.PluralName = "IsoCodes";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.IsUnique = true;
		relationType.RoleType.Size = 256;
		MetaCurrency.Instance.IsoCode = relationType.RoleType; 
	}
	}


	private void BuildRolesLanguage() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("d2a32d9f-21cc-4f9d-b0d3-a9b75da66907"), new System.Guid("6c860e73-d12e-4e35-897e-ed9f8fd8eba0"), new System.Guid("84f904a6-8dcc-4089-bda6-34325ade6367"));
		relationType.AssociationType.ObjectType = MetaLanguage.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "IsoCode";
		relationType.RoleType.PluralName = "IsoCodes";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.IsUnique = true;
		relationType.RoleType.Size = 256;
		MetaLanguage.Instance.IsoCode = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("be482902-beb5-4a76-8ad0-c1b1c1c0e5c4"), new System.Guid("d3369fa9-afb7-4d5a-b476-3e4d43cce0fd"), new System.Guid("308d73b0-1b65-40a9-88f1-288848849c51"));
		relationType.AssociationType.ObjectType = MetaLanguage.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.IsUnique = true;
		relationType.RoleType.Size = 256;
		MetaLanguage.Instance.Name = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("f091b264-e6b1-4a57-bbfb-8225cbe8190c"), new System.Guid("6650af3b-f537-4c2f-afff-6773552315cd"), new System.Guid("5e9fcced-727d-42a2-95e6-a0f9d8be4ec7"));
		relationType.AssociationType.ObjectType = MetaLanguage.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaLocalisedText.Instance;
		relationType.RoleType.SingularName = "LocalisedName";
		relationType.RoleType.PluralName = "LocalisedNames";
		MetaLanguage.Instance.LocalisedNames = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("842CC899-3F37-455A-AE91-51D29D615E69"), new System.Guid("F3C7A07E-A2F3-4A96-91EF-D53DDF009DD4"), new System.Guid("C78E1736-74B4-4574-A365-421DCADF4D4C"));
		relationType.AssociationType.ObjectType = MetaLanguage.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "NativeName";
		relationType.RoleType.PluralName = "NativeNames";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.Size = 256;
		MetaLanguage.Instance.NativeName = relationType.RoleType; 
	}
	}


	private void BuildRolesLocale() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("2a2c6f77-e6a2-4eab-bfe3-5d35a8abd7f7"), new System.Guid("09422255-fa17-41d8-991b-d21d7b37c6c5"), new System.Guid("647db2b3-997b-4c3a-9ae2-d49b410933c1"));
		relationType.AssociationType.ObjectType = MetaLocale.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.Size = 256;
		MetaLocale.Instance.Name = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("d8cac34a-9bb2-4190-bd2a-ec0b87e04cf5"), new System.Guid("af501892-3c83-41d1-826b-f5c4cb1de7fe"), new System.Guid("ed32b12a-00ad-420b-9dfa-f1c6ce773fcd"));
		relationType.AssociationType.ObjectType = MetaLocale.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaLanguage.Instance;
		relationType.RoleType.SingularName = "Language";
		relationType.RoleType.PluralName = "Languages";
		relationType.RoleType.IsRequired = true;
		MetaLocale.Instance.Language = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("ea778b77-2929-4ab4-ad99-bf2f970401a9"), new System.Guid("bb5904f5-feb0-47eb-903a-0351d55f0d8c"), new System.Guid("b2fc6e06-3881-427e-b4cc-8457a65f8076"));
		relationType.AssociationType.ObjectType = MetaLocale.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaCountry.Instance;
		relationType.RoleType.SingularName = "Country";
		relationType.RoleType.PluralName = "Countries";
		relationType.RoleType.IsRequired = true;
		MetaLocale.Instance.Country = relationType.RoleType; 
	}
	}


	private void BuildRolesLocalisedText() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("50dc85f0-3d22-4bc1-95d9-153674b89f7a"), new System.Guid("accd061b-20b9-4a24-bb2c-c2f7276f43ab"), new System.Guid("8d3f68e1-fa6e-414f-aa4d-25fcc2c975d6"));
		relationType.AssociationType.ObjectType = MetaLocalisedText.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Text";
		relationType.RoleType.PluralName = "Texts";
		relationType.RoleType.Size = -1;
		MetaLocalisedText.Instance.Text = relationType.RoleType; 
	}
	}


	private void BuildRolesAccessControl() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("0dbbff5c-3dca-4257-b2da-442d263dcd86"), new System.Guid("92e8d639-9205-422b-b4ff-c7e8c2980abf"), new System.Guid("2d9b7157-5409-40d3-bd3e-6911df9aface"));
		relationType.AssociationType.ObjectType = MetaAccessControl.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUserGroup.Instance;
		relationType.RoleType.SingularName = "SubjectGroup";
		relationType.RoleType.PluralName = "SubjectGroups";
		MetaAccessControl.Instance.SubjectGroups = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("37dd1e27-ba75-404c-9410-c6399d28317c"), new System.Guid("3d74101d-97bc-46fb-9548-96cb7aa01b39"), new System.Guid("e0303a17-bf7a-4a7f-bb4b-0a447c56aaaf"));
		relationType.AssociationType.ObjectType = MetaAccessControl.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUser.Instance;
		relationType.RoleType.SingularName = "Subject";
		relationType.RoleType.PluralName = "Subjects";
		MetaAccessControl.Instance.Subjects = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("69a9dae8-678d-4c1c-a464-2e5aa5caf39e"), new System.Guid("ec79e57d-be81-430a-b12f-08ffd1e94af3"), new System.Guid("370d3d12-3164-4753-8a72-1c604bda1b64"));
		relationType.AssociationType.ObjectType = MetaAccessControl.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaRole.Instance;
		relationType.RoleType.SingularName = "Role";
		relationType.RoleType.PluralName = "Roles";
		relationType.RoleType.IsRequired = true;
		MetaAccessControl.Instance.Role = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("5e218f37-3b07-4002-87a4-7581a53f01ba"), new System.Guid("be94d5f0-df53-4118-987a-11bce8593a1b"), new System.Guid("46d65185-9e0d-4347-a38f-6afa2431c241"));
		relationType.AssociationType.ObjectType = MetaAccessControl.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaPermission.Instance;
		relationType.RoleType.SingularName = "EffectivePermission";
		relationType.RoleType.PluralName = "EffectivePermissions";
		MetaAccessControl.Instance.EffectivePermissions = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("50ecae85-e5a9-467e-99a3-78703d954b2f"), new System.Guid("01590aea-d75c-45be-af4b-bf56545a4008"), new System.Guid("bac6c53c-e103-42cb-b36d-2faa00ebf574"));
		relationType.AssociationType.ObjectType = MetaAccessControl.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUser.Instance;
		relationType.RoleType.SingularName = "EffectiveUser";
		relationType.RoleType.PluralName = "EffectiveUsers";
		MetaAccessControl.Instance.EffectiveUsers = relationType.RoleType; 
	}
	}


	private void BuildRolesLogin() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("18262218-a14f-48c3-87a5-87196d3b5974"), new System.Guid("3f067cf5-4fcb-4be4-9afb-15ba37700658"), new System.Guid("e5393717-f46c-4a4c-a87f-3e4684428860"));
		relationType.AssociationType.ObjectType = MetaLogin.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Key";
		relationType.RoleType.PluralName = "Keys";
		relationType.RoleType.Size = 256;
		MetaLogin.Instance.Key = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("7a82e721-d0b7-4567-aaef-bd3987ae6d01"), new System.Guid("2f2ef41d-8310-45fd-8ab5-e5d067862e3d"), new System.Guid("c8e3851a-bc57-4acb-934a-4adfc37b1da7"));
		relationType.AssociationType.ObjectType = MetaLogin.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Provider";
		relationType.RoleType.PluralName = "Providers";
		relationType.RoleType.Size = 256;
		MetaLogin.Instance.Provider = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("c2d950ad-39d3-40f1-8817-11a026e9890b"), new System.Guid("e8091111-9f92-41a9-b4b1-4e8f277ea575"), new System.Guid("150daf84-13ce-4b5f-83e6-64c7ef4f81c6"));
		relationType.AssociationType.ObjectType = MetaLogin.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUser.Instance;
		relationType.RoleType.SingularName = "User";
		relationType.RoleType.PluralName = "Users";
		MetaLogin.Instance.User = relationType.RoleType; 
	}
	}


	private void BuildRolesPermission() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("097bb620-f068-440e-8d02-ef9d8be1d0f0"), new System.Guid("3442728c-164a-477c-87be-19a789229585"), new System.Guid("3fd81194-2f6f-43e7-9c6b-91f5e3e118ac"));
		relationType.AssociationType.ObjectType = MetaPermission.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUnique.Instance;
		relationType.RoleType.SingularName = "OperandTypePointer";
		relationType.RoleType.PluralName = "OperandTypePointers";
		relationType.RoleType.IsRequired = true;
		MetaPermission.Instance.OperandTypePointer = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("29b80857-e51b-4dec-b859-887ed74b1626"), new System.Guid("8ffed1eb-b64e-4341-bbb6-348ed7f06e83"), new System.Guid("cadaca05-55ba-4a13-8758-786ff29c8e46"));
		relationType.AssociationType.ObjectType = MetaPermission.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUnique.Instance;
		relationType.RoleType.SingularName = "ConcreteClassPointer";
		relationType.RoleType.PluralName = "ConcreteClassPointers";
		relationType.RoleType.IsRequired = true;
		MetaPermission.Instance.ConcreteClassPointer = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("9d73d437-4918-4f20-b9a7-3ce23a04bd7b"), new System.Guid("891734d6-4855-4b33-8b3b-f46fd6103149"), new System.Guid("d29ce0ed-fba8-409d-8675-dc95e1566cfb"));
		relationType.AssociationType.ObjectType = MetaPermission.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaInteger.Instance;
		relationType.RoleType.SingularName = "OperationEnum";
		relationType.RoleType.PluralName = "OperationEnums";
		relationType.RoleType.IsRequired = true;
		MetaPermission.Instance.OperationEnum = relationType.RoleType; 
	}
	}


	private void BuildRolesRole() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("51e56ae1-72dc-443f-a2a3-f5aa3650f8d2"), new System.Guid("47af1a0f-497d-4a19-887b-79e5fb77c8bd"), new System.Guid("7e6a71b0-2194-47f8-b562-cb4a15e335b6"));
		relationType.AssociationType.ObjectType = MetaRole.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaPermission.Instance;
		relationType.RoleType.SingularName = "Permission";
		relationType.RoleType.PluralName = "Permissions";
		MetaRole.Instance.Permissions = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("934bcbbe-5286-445c-a1bd-e2fcc786c448"), new System.Guid("05785884-ca83-43de-a6f3-86d3fa7ec82a"), new System.Guid("8d87c74f-53ed-4e1d-a2ea-12190ac233d2"));
		relationType.AssociationType.ObjectType = MetaRole.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.IsUnique = true;
		relationType.RoleType.Size = 256;
		MetaRole.Instance.Name = relationType.RoleType; 
	}
	}


	private void BuildRolesSecurityToken() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("6503574b-8bab-4da8-a19d-23a9bcffe01e"), new System.Guid("cae9e5c2-afa1-46f4-b930-69d4e810038f"), new System.Guid("ab2b4b9c-87dd-4712-b123-f5f9271c6193"));
		relationType.AssociationType.ObjectType = MetaSecurityToken.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaAccessControl.Instance;
		relationType.RoleType.SingularName = "AccessControl";
		relationType.RoleType.PluralName = "AccessControls";
		MetaSecurityToken.Instance.AccessControls = relationType.RoleType; 
	}
	}


	private void BuildRolesAutomatedAgent() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("4e158d75-d0b5-4cb7-ad41-e8ed3002d175"), new System.Guid("6f2a83eb-17e9-408e-b18b-9bb2b9a3e812"), new System.Guid("4fac2dd3-8711-4115-96b9-a38f62e2d093"));
		relationType.AssociationType.ObjectType = MetaAutomatedAgent.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.Size = 256;
		MetaAutomatedAgent.Instance.Name = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("58870c93-b066-47b7-95f7-5411a46dbc7e"), new System.Guid("31925ed6-e66c-4718-963f-c8a71d566fe8"), new System.Guid("eee42775-b172-4fde-9042-a0f9b2224ec3"));
		relationType.AssociationType.ObjectType = MetaAutomatedAgent.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Description";
		relationType.RoleType.PluralName = "Descriptions";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.Size = -1;
		MetaAutomatedAgent.Instance.Description = relationType.RoleType; 
	}
	}


	private void BuildRolesEmailMessage() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("5de25d18-3c36-418f-9c85-55a480d58bc5"), new System.Guid("1b4eb236-b359-40ff-ba67-2e1623844f78"), new System.Guid("57dc2c2a-949b-497b-880f-b1df13e0e12f"));
		relationType.AssociationType.ObjectType = MetaEmailMessage.Instance;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaDateTime.Instance;
		relationType.RoleType.SingularName = "DateCreated";
		relationType.RoleType.PluralName = "DateCreateds";
		relationType.RoleType.IsRequired = true;
		MetaEmailMessage.Instance.DateCreated = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("c297ff40-e2ad-46af-94fc-c61af6e6a6d6"), new System.Guid("366767a9-d82d-408d-9c06-7256724aa578"), new System.Guid("29b77e2c-9590-4da9-a616-f67e84187644"));
		relationType.AssociationType.ObjectType = MetaEmailMessage.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaDateTime.Instance;
		relationType.RoleType.SingularName = "DateSending";
		relationType.RoleType.PluralName = "DateSendings";
		MetaEmailMessage.Instance.DateSending = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("cc36e90a-dcda-4289-b84f-c947c97847b0"), new System.Guid("9b3d2505-103a-4801-9f16-f1f7ca924f57"), new System.Guid("ae7bedca-c966-4cd5-9a8a-b99f3fc5e0bc"));
		relationType.AssociationType.ObjectType = MetaEmailMessage.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaDateTime.Instance;
		relationType.RoleType.SingularName = "DateSent";
		relationType.RoleType.PluralName = "DateSents";
		MetaEmailMessage.Instance.DateSent = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("e16da480-35ab-4383-940a-5298d0b33b9c"), new System.Guid("5be8bb0f-cead-44f6-813b-1125882618b7"), new System.Guid("4cca6d37-fffe-4e78-962c-f4474551e09e"));
		relationType.AssociationType.ObjectType = MetaEmailMessage.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUser.Instance;
		relationType.RoleType.SingularName = "Sender";
		relationType.RoleType.PluralName = "Senders";
		MetaEmailMessage.Instance.Sender = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("d115bcfb-55e5-4ed8-8a21-f8e4dd5f903d"), new System.Guid("55c3f9b5-1a80-419d-93cc-6c19925e350e"), new System.Guid("8e8749da-4411-4dfa-bd78-856f37e1a4ba"));
		relationType.AssociationType.ObjectType = MetaEmailMessage.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUser.Instance;
		relationType.RoleType.SingularName = "Recipient";
		relationType.RoleType.PluralName = "Recipients";
		MetaEmailMessage.Instance.Recipients = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("CD9C9D1E-3393-46B4-AD61-7AC03019EE08"), new System.Guid("EC809FF4-98BB-4DFA-9D18-1D321A2BC871"), new System.Guid("6846A2B4-DFC4-436E-81E2-C504DD020546"));
		relationType.AssociationType.ObjectType = MetaEmailMessage.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "RecipientEmailAddress";
		relationType.RoleType.PluralName = "RecipientEmailAddresses";
		relationType.RoleType.Size = 256;
		MetaEmailMessage.Instance.RecipientEmailAddress = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("5666ebec-8205-4e5f-b0df-cacfa1af99ce"), new System.Guid("1adc0465-9b6b-4050-9b0a-e7fe441ccbd5"), new System.Guid("f19705f3-5323-4360-8602-acee1be80c50"));
		relationType.AssociationType.ObjectType = MetaEmailMessage.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Subject";
		relationType.RoleType.PluralName = "Subjects";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.Size = 1024;
		MetaEmailMessage.Instance.Subject = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("25be1f1c-ea8b-471e-ad09-b618927dc15a"), new System.Guid("0b9ec5be-fe85-407c-8a35-434ede55bd3b"), new System.Guid("b331b4dd-7bfa-479d-91f2-9376955207ef"));
		relationType.AssociationType.ObjectType = MetaEmailMessage.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Body";
		relationType.RoleType.PluralName = "Bodies";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.Size = -1;
		MetaEmailMessage.Instance.Body = relationType.RoleType; 
	}
	}


	private void BuildRolesNotification() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("9a226bec-31b9-413e-bec1-8dcdf36fa6fb"), new System.Guid("c05db652-e6b0-485b-bcf5-9ec77a20d068"), new System.Guid("db9f708f-ac35-49f4-a62a-9df9863da8bd"));
		relationType.AssociationType.ObjectType = MetaNotification.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUniquelyIdentifiable.Instance;
		relationType.RoleType.SingularName = "Target";
		relationType.RoleType.PluralName = "Targets";
		MetaNotification.Instance.Target = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("50b1be30-d6a9-49e8-84da-a47647e443f0"), new System.Guid("cb7cc442-b05b-48a5-8696-4baab7aa8cce"), new System.Guid("3ee1975d-5019-4043-be5f-65331ef58787"));
		relationType.AssociationType.ObjectType = MetaNotification.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaBoolean.Instance;
		relationType.RoleType.SingularName = "Confirmed";
		relationType.RoleType.PluralName = "Confirmeds";
		relationType.RoleType.IsRequired = true;
		MetaNotification.Instance.Confirmed = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("70292962-9e0e-4b57-a710-c8ac34f65b11"), new System.Guid("80e4d1c5-5648-486a-a2ff-3b1690514f20"), new System.Guid("84813900-abe0-4c24-bd2e-5b0d6be5ab6c"));
		relationType.AssociationType.ObjectType = MetaNotification.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Title";
		relationType.RoleType.PluralName = "Titles";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.Size = 1024;
		MetaNotification.Instance.Title = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("e83600fc-5411-4c72-9903-80a3741a9165"), new System.Guid("1da1555c-fee6-4084-be37-57a6f58fe591"), new System.Guid("a6f6ed43-b0ab-462f-9be9-fad58d2e8398"));
		relationType.AssociationType.ObjectType = MetaNotification.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Description";
		relationType.RoleType.PluralName = "Descriptions";
		relationType.RoleType.Size = -1;
		MetaNotification.Instance.Description = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("458a8223-9c0f-4475-93c0-82d5cc133f1b"), new System.Guid("8d657749-a823-422b-9e29-041453ccb267"), new System.Guid("d100a845-df65-4f06-96b8-dcaeb9c3e205"));
		relationType.AssociationType.ObjectType = MetaNotification.Instance;
		relationType.Workspace = true;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaDateTime.Instance;
		relationType.RoleType.SingularName = "DateCreated";
		relationType.RoleType.PluralName = "DateCreateds";
		relationType.RoleType.IsRequired = true;
		MetaNotification.Instance.DateCreated = relationType.RoleType; 
	}
	}


	private void BuildRolesNotificationList() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("4516c5c1-73a0-4fdc-ac3c-aefaf417c8ba"), new System.Guid("7fb512b5-3440-444a-9562-ad3655e551e5"), new System.Guid("9b7d6984-98cb-4367-a6fc-9b07c9101fda"));
		relationType.AssociationType.ObjectType = MetaNotificationList.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaNotification.Instance;
		relationType.RoleType.SingularName = "Notification";
		relationType.RoleType.PluralName = "Notifications";
		MetaNotificationList.Instance.Notifications = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("89487904-053e-470f-bcf9-0e01165b0143"), new System.Guid("2d41d7ef-d107-404f-ac9d-fb81105d3ff7"), new System.Guid("fc089f2e-a625-40f9-bbc0-c9fc05e6e599"));
		relationType.AssociationType.ObjectType = MetaNotificationList.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaNotification.Instance;
		relationType.RoleType.SingularName = "UnconfirmedNotification";
		relationType.RoleType.PluralName = "UnconfirmedNotifications";
		MetaNotificationList.Instance.UnconfirmedNotifications = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("438fdc30-25ac-4d33-9a55-0ef817c05479"), new System.Guid("34a36081-e093-4d8b-ae87-4a3df329f7a1"), new System.Guid("b752a7c3-433c-4b54-bbc1-0f812d5afb16"));
		relationType.AssociationType.ObjectType = MetaNotificationList.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaNotification.Instance;
		relationType.RoleType.SingularName = "ConfirmedNotification";
		relationType.RoleType.PluralName = "ConfirmedNotifications";
		MetaNotificationList.Instance.ConfirmedNotifications = relationType.RoleType; 
	}
	}


	private void BuildRolesTaskAssignment() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("c32c19f1-3f41-4d11-b19d-b8b2aa360166"), new System.Guid("6e08b1d8-f7fa-452d-907a-668bf32702c1"), new System.Guid("407443f4-5afa-484e-be97-88ef19f00b32"));
		relationType.AssociationType.ObjectType = MetaTaskAssignment.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUser.Instance;
		relationType.RoleType.SingularName = "User";
		relationType.RoleType.PluralName = "Users";
		relationType.RoleType.IsRequired = true;
		MetaTaskAssignment.Instance.User = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("f4e05932-89c0-4f40-b4b2-f241ac42d8a0"), new System.Guid("d1f61b05-8f54-47b6-87dd-fd7b66ef0b50"), new System.Guid("86589718-3284-43e9-8f3e-a0f5faa30357"));
		relationType.AssociationType.ObjectType = MetaTaskAssignment.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaNotification.Instance;
		relationType.RoleType.SingularName = "Notification";
		relationType.RoleType.PluralName = "Notifications";
		MetaTaskAssignment.Instance.Notification = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("8a01f221-480f-4d61-9a12-72e3689a8224"), new System.Guid("e5e52776-c946-42b0-99f4-596ffc1c298f"), new System.Guid("0be6c69a-1d1c-49d0-8247-fa0ff9a8f223"));
		relationType.AssociationType.ObjectType = MetaTaskAssignment.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaTask.Instance;
		relationType.RoleType.SingularName = "Task";
		relationType.RoleType.PluralName = "Tasks";
		relationType.RoleType.IsRequired = true;
		MetaTaskAssignment.Instance.Task = relationType.RoleType; 
	}
	}


	private void BuildRolesTaskList() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("c3467693-cc18-46e5-a0af-d7ab0cbe9faa"), new System.Guid("7976dbaa-9b96-401f-900d-db76fd45f18f"), new System.Guid("3922d9e8-e518-4459-8b52-0723104456ab"));
		relationType.AssociationType.ObjectType = MetaTaskList.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaTaskAssignment.Instance;
		relationType.RoleType.SingularName = "TaskAssignment";
		relationType.RoleType.PluralName = "TaskAssignments";
		MetaTaskList.Instance.TaskAssignments = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("2e7381c6-3a58-4a64-8808-4f3532254f08"), new System.Guid("63efedc3-1157-4ae0-b212-9169cd0ac418"), new System.Guid("4f83aaac-7ba1-4fdc-9ddf-781559ff3983"));
		relationType.AssociationType.ObjectType = MetaTaskList.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaTaskAssignment.Instance;
		relationType.RoleType.SingularName = "OpenTaskAssignment";
		relationType.RoleType.PluralName = "OpenTaskAssignments";
		MetaTaskList.Instance.OpenTaskAssignments = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("bc07648e-b80c-42f6-a4dd-113fba962c89"), new System.Guid("c3b078cf-27ee-4686-b7ff-ba40a7aba5a7"), new System.Guid("ef37d700-cfa6-4998-9501-9d09bb9ac1d8"));
		relationType.AssociationType.ObjectType = MetaTaskList.Instance;
		relationType.Workspace = true;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaInteger.Instance;
		relationType.RoleType.SingularName = "Count";
		relationType.RoleType.PluralName = "Counts";
		MetaTaskList.Instance.Count = relationType.RoleType; 
	}
	}


	private void BuildRolesUserGroup() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("585bb5cf-9ba4-4865-9027-3667185abc4f"), new System.Guid("1e2d1e31-ed80-4435-8850-7663d9c5f41d"), new System.Guid("c552f0b7-95ce-4d45-aaea-56bc8365eee4"));
		relationType.AssociationType.ObjectType = MetaUserGroup.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUser.Instance;
		relationType.RoleType.SingularName = "Member";
		relationType.RoleType.PluralName = "Members";
		MetaUserGroup.Instance.Members = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("e94e7f05-78bd-4291-923f-38f82d00e3f4"), new System.Guid("75859e2c-c1a3-4f4c-bb37-4064d0aa81d0"), new System.Guid("9d3c1eec-bf10-4a79-a37f-bc6a20ff2a79"));
		relationType.AssociationType.ObjectType = MetaUserGroup.Instance;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.IsUnique = true;
		relationType.RoleType.Size = 256;
		MetaUserGroup.Instance.Name = relationType.RoleType; 
	}
	}


	private void BuildRolesObject() {

	}


	private void BuildRolesCachable() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("EF6F1F4C-5B62-49DC-9D05-0F02973ACCB3"), new System.Guid("1137FDD3-07E6-432E-8C42-273EF24863D5"), new System.Guid("D6A473F7-4EFF-4D3D-BDB2-59F5EE8B0E52"));
		relationType.AssociationType.ObjectType = MetaCachable.Instance;
		relationType.RoleType.ObjectType = MetaUnique.Instance;
		relationType.RoleType.SingularName = "CacheId";
		relationType.RoleType.PluralName = "CacheIds";
		relationType.RoleType.IsRequired = true;
		MetaCachable.Instance.CacheId = relationType.RoleType; 
	}
	}


	private void BuildRolesDeletable() {

	}


	private void BuildRolesEnumeration() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("3d3ae4d0-bac6-4645-8a53-3e9f7f9af086"), new System.Guid("004cc333-b8ae-4952-ae13-f2ab80eb018c"), new System.Guid("5850860d-c772-402f-815b-7634c9a1e697"));
		relationType.AssociationType.ObjectType = MetaEnumeration.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.IsRequired = true;
		relationType.RoleType.Size = 256;
		MetaEnumeration.Instance.Name = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("07e034f1-246a-4115-9662-4c798f31343f"), new System.Guid("bcf428fd-0263-488c-b9ac-963ceca1c972"), new System.Guid("919fdad7-830e-4b12-b23c-f433951236af"));
		relationType.AssociationType.ObjectType = MetaEnumeration.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaLocalisedText.Instance;
		relationType.RoleType.SingularName = "LocalisedName";
		relationType.RoleType.PluralName = "LocalisedNames";
		MetaEnumeration.Instance.LocalisedNames = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("f57bb62e-77a8-4519-81e6-539d54b71cb7"), new System.Guid("a8993304-52c0-4b53-9982-6caa5675467a"), new System.Guid("0c6faf5a-eac9-454c-bd53-3b8409e56d34"));
		relationType.AssociationType.ObjectType = MetaEnumeration.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaBoolean.Instance;
		relationType.RoleType.SingularName = "IsActive";
		relationType.RoleType.PluralName = "IsActives";
		MetaEnumeration.Instance.IsActive = relationType.RoleType; 
	}
	}


	private void BuildRolesUniquelyIdentifiable() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("e1842d87-8157-40e7-b06e-4375f311f2c3"), new System.Guid("fe413e96-cfcf-4e8d-9f23-0fa4f457fdf1"), new System.Guid("d73fd9a4-13ee-4fa9-8925-d93eca328bf6"));
		relationType.AssociationType.ObjectType = MetaUniquelyIdentifiable.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaUnique.Instance;
		relationType.RoleType.SingularName = "UniqueId";
		relationType.RoleType.PluralName = "UniqueIds";
		relationType.RoleType.IsRequired = true;
		MetaUniquelyIdentifiable.Instance.UniqueId = relationType.RoleType; 
	}
	}


	private void BuildRolesVersion() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("9FAEB940-A3A0-4E7A-B889-BCFD92F6A882"), new System.Guid("4C4BD3D4-6642-48AA-8C29-46C02DCDC749"), new System.Guid("FD06C364-1033-423C-B297-DC6EDF15F4FD"));
		relationType.AssociationType.ObjectType = MetaVersion.Instance;
		relationType.RoleType.ObjectType = MetaUnique.Instance;
		relationType.RoleType.SingularName = "DerivationId";
		relationType.RoleType.PluralName = "DerivationIds";
		MetaVersion.Instance.DerivationId = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("ADF611C3-047A-4BAE-95E3-776022D5CE7B"), new System.Guid("7145B062-AEE9-4B30-ADB8-C691969C6874"), new System.Guid("B38C700C-7AD9-4962-9F53-35B8AEF22E09"));
		relationType.AssociationType.ObjectType = MetaVersion.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaDateTime.Instance;
		relationType.RoleType.SingularName = "DerivationTimeStamp";
		relationType.RoleType.PluralName = "DerivationTimeStamps";
		MetaVersion.Instance.DerivationTimeStamp = relationType.RoleType; 
	}
	}


	private void BuildRolesVersioned() {

	}


	private void BuildRolesLocalised() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("8c005a4e-5ffe-45fd-b279-778e274f4d83"), new System.Guid("6684d98b-cd43-4612-bf9d-afefe02a0d43"), new System.Guid("d43b92ac-9e6f-4238-9625-1e889be054cf"));
		relationType.AssociationType.ObjectType = MetaLocalised.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaLocale.Instance;
		relationType.RoleType.SingularName = "Locale";
		relationType.RoleType.PluralName = "Locales";
		MetaLocalised.Instance.Locale = relationType.RoleType; 
	}
	}


	private void BuildRolesAccessControlledObject() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("5c70ca14-4601-4c65-9b0d-cb189f90be27"), new System.Guid("267053f0-43b4-4cc7-a0e2-103992b2d0c5"), new System.Guid("867765fa-49dc-462f-b430-3c0e264c5283"));
		relationType.AssociationType.ObjectType = MetaAccessControlledObject.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaPermission.Instance;
		relationType.RoleType.SingularName = "DeniedPermission";
		relationType.RoleType.PluralName = "DeniedPermissions";
		MetaAccessControlledObject.Instance.DeniedPermissions = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("b816fccd-08e0-46e0-a49c-7213c3604416"), new System.Guid("1739db0d-fe6b-42e1-a6a5-286536ff4f56"), new System.Guid("9f722315-385a-42ab-b84e-83063b0e5b0d"));
		relationType.AssociationType.ObjectType = MetaAccessControlledObject.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaSecurityToken.Instance;
		relationType.RoleType.SingularName = "SecurityToken";
		relationType.RoleType.PluralName = "SecurityTokens";
		MetaAccessControlledObject.Instance.SecurityTokens = relationType.RoleType; 
	}
	}


	private void BuildRolesDelegatedAccessControlledObject() {

	}


	private void BuildRolesSecurityTokenOwner() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("5fb15e8b-011c-46f7-83dd-485d4cc4f9f2"), new System.Guid("cdc21c1c-918e-4622-a01f-a3de06a8c802"), new System.Guid("2acda9b3-89e8-475f-9d70-b9cde334409c"));
		relationType.AssociationType.ObjectType = MetaSecurityTokenOwner.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaSecurityToken.Instance;
		relationType.RoleType.SingularName = "OwnerSecurityToken";
		relationType.RoleType.PluralName = "OwnerSecurityTokens";
		relationType.RoleType.IsRequired = true;
		MetaSecurityTokenOwner.Instance.OwnerSecurityToken = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("056914ed-a658-4ae5-b859-97300e1b8911"), new System.Guid("04b811b2-71b1-46a9-9ef5-1c061a035f07"), new System.Guid("ea2ecc92-0657-4ae9-a21d-4487353e7d00"));
		relationType.AssociationType.ObjectType = MetaSecurityTokenOwner.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaAccessControl.Instance;
		relationType.RoleType.SingularName = "OwnerAccessControl";
		relationType.RoleType.PluralName = "OwnerAccessControls";
		MetaSecurityTokenOwner.Instance.OwnerAccessControl = relationType.RoleType; 
	}
	}


	private void BuildRolesObjectState() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("59338f0b-40e7-49e8-ba1a-3ecebf96aebe"), new System.Guid("fca0f3f6-bdd6-4405-93b3-35dd769bff0e"), new System.Guid("c338f087-559c-4239-9c6a-1f691e58ed16"));
		relationType.AssociationType.ObjectType = MetaObjectState.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaPermission.Instance;
		relationType.RoleType.SingularName = "DeniedPermission";
		relationType.RoleType.PluralName = "DeniedPermissions";
		MetaObjectState.Instance.DeniedPermissions = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("b86f9e42-fe10-4302-ab7c-6c6c7d357c39"), new System.Guid("052ec640-3150-458a-99d5-0edce6eb6149"), new System.Guid("945cbba6-4b09-4b87-931e-861b147c3823"));
		relationType.AssociationType.ObjectType = MetaObjectState.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "Name";
		relationType.RoleType.PluralName = "Names";
		relationType.RoleType.Size = 256;
		MetaObjectState.Instance.Name = relationType.RoleType; 
	}
	}


	private void BuildRolesTask() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("f247de73-70fe-47e4-a763-22ee9c68a476"), new System.Guid("2e1ebe97-52d3-46fc-94c2-3203a13856c7"), new System.Guid("4ca8997f-9232-4c84-8f37-e977071eb316"));
		relationType.AssociationType.ObjectType = MetaTask.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaWorkItem.Instance;
		relationType.RoleType.SingularName = "WorkItem";
		relationType.RoleType.PluralName = "WorkItems";
		relationType.RoleType.IsRequired = true;
		MetaTask.Instance.WorkItem = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("8ebd9048-a344-417c-bae7-359ca9a74aa1"), new System.Guid("af6cbf34-5f71-498b-a2ec-ef698eeae799"), new System.Guid("ceba2888-2a6e-4822-881b-1101b48f80f3"));
		relationType.AssociationType.ObjectType = MetaTask.Instance;
		relationType.Workspace = true;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaDateTime.Instance;
		relationType.RoleType.SingularName = "DateCreated";
		relationType.RoleType.PluralName = "DateCreateds";
		relationType.RoleType.IsRequired = true;
		MetaTask.Instance.DateCreated = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("5ad0b9f5-669c-4b05-8c97-89b59a227da2"), new System.Guid("b3182870-cbe0-4da1-aaeb-804df5a9f869"), new System.Guid("eacac26b-fea7-49f8-abb6-57d63accd548"));
		relationType.AssociationType.ObjectType = MetaTask.Instance;
		relationType.Workspace = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaDateTime.Instance;
		relationType.RoleType.SingularName = "DateClosed";
		relationType.RoleType.PluralName = "DateCloseds";
		MetaTask.Instance.DateClosed = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("55375d57-34b0-43d0-9fac-e9788e1b6cd2"), new System.Guid("0d421578-35fc-4309-b8b6-cda0c9cf948c"), new System.Guid("a7c8f58f-358a-4ae9-9299-0ef560190541"));
		relationType.AssociationType.ObjectType = MetaTask.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaPerson.Instance;
		relationType.RoleType.SingularName = "Participant";
		relationType.RoleType.PluralName = "Participants";
		MetaTask.Instance.Participants = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("ea8abc59-b625-4d25-85bd-dd04bfe55086"), new System.Guid("90150444-fc18-47fd-a6fd-7740006e64ca"), new System.Guid("34320d76-6803-4615-8444-cc3ea8bb0315"));
		relationType.AssociationType.ObjectType = MetaTask.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaPerson.Instance;
		relationType.RoleType.SingularName = "Performer";
		relationType.RoleType.PluralName = "Performers";
		MetaTask.Instance.Performer = relationType.RoleType; 
	}
	}


	private void BuildRolesTransitional() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("D9D86241-5FC7-4EDB-9FAA-FF5CA291F16C"), new System.Guid("C6D64EB2-4921-4AD9-9DC3-12BDCB8E7D97"), new System.Guid("292A7D78-3DA8-401C-A4D1-513F61114615"));
		relationType.AssociationType.ObjectType = MetaTransitional.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaObjectState.Instance;
		relationType.RoleType.SingularName = "PreviousObjectState";
		relationType.RoleType.PluralName = "PreviousObjectStates";
		MetaTransitional.Instance.PreviousObjectStates = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("2BC8AFDF-92BE-4088-9E35-C1C942CFE74B"), new System.Guid("549BC4A5-42B5-46D8-B487-9D1255BC1B8E"), new System.Guid("CA573AAD-72CC-4315-971D-43526D1A964B"));
		relationType.AssociationType.ObjectType = MetaTransitional.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaObjectState.Instance;
		relationType.RoleType.SingularName = "LastObjectState";
		relationType.RoleType.PluralName = "LastObjectStates";
		MetaTransitional.Instance.LastObjectStates = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("52962C45-8A3E-4136-A968-C333CBE12685"), new System.Guid("B49A45EE-302E-4893-BEAD-88764D0774FF"), new System.Guid("08BBEF2B-47A4-48B0-86E2-522F3B584426"));
		relationType.AssociationType.ObjectType = MetaTransitional.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaObjectState.Instance;
		relationType.RoleType.SingularName = "ObjectState";
		relationType.RoleType.PluralName = "ObjectStates";
		MetaTransitional.Instance.ObjectStates = relationType.RoleType; 
	}
	}


	private void BuildRolesTransitionalVersion() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("96685F17-ABE3-459C-BF9F-8C5F05788C04"), new System.Guid("40D11625-EF9F-4358-9FC0-5C29248E41DA"), new System.Guid("3893BB57-1EA6-4DEE-8248-483269CA30DA"));
		relationType.AssociationType.ObjectType = MetaTransitionalVersion.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsSynced = true;
		relationType.RoleType.ObjectType = MetaObjectState.Instance;
		relationType.RoleType.SingularName = "PreviousObjectState";
		relationType.RoleType.PluralName = "PreviousObjectStates";
		MetaTransitionalVersion.Instance.PreviousObjectStates = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("39C43EB4-AA16-4CF8-93A0-60066CB746E8"), new System.Guid("AEB8A1DC-D214-429E-9A78-6FD60B419BE0"), new System.Guid("DAC764A7-417C-4E24-985C-63171F7DC347"));
		relationType.AssociationType.ObjectType = MetaTransitionalVersion.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsSynced = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaObjectState.Instance;
		relationType.RoleType.SingularName = "LastObjectState";
		relationType.RoleType.PluralName = "LastObjectStates";
		MetaTransitionalVersion.Instance.LastObjectStates = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("F2472C1F-8D2A-4400-B372-34C2B03207B6"), new System.Guid("08C19B44-2015-4BCA-B0E2-AB8CA626485F"), new System.Guid("6C37AE50-8727-4391-A0E8-3596D5E2070F"));
		relationType.AssociationType.ObjectType = MetaTransitionalVersion.Instance;
		relationType.AssignedMultiplicity = Allors.Multiplicity.ManyToMany;
		relationType.IsSynced = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaObjectState.Instance;
		relationType.RoleType.SingularName = "ObjectState";
		relationType.RoleType.PluralName = "ObjectStates";
		MetaTransitionalVersion.Instance.ObjectStates = relationType.RoleType; 
	}
	}


	private void BuildRolesUser() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("5e8ab257-1a1c-4448-aacc-71dbaaba525b"), new System.Guid("eca7ef36-8928-4116-bfce-1896a685fe8c"), new System.Guid("3b7d40a0-18ea-4018-b797-6417723e1890"));
		relationType.AssociationType.ObjectType = MetaUser.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "UserName";
		relationType.RoleType.PluralName = "UserNames";
		relationType.RoleType.Size = 256;
		MetaUser.Instance.UserName = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("7397B596-D8FA-4E3C-8E0E-EA24790FE2E4"), new System.Guid("19CAD82C-6538-4C46-AA3F-75C082CC8204"), new System.Guid("FAF89920-880F-4600-BAF1-A27A5268444A"));
		relationType.AssociationType.ObjectType = MetaUser.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "NormalizedUserName";
		relationType.RoleType.PluralName = "NormalizedUserNames";
		relationType.RoleType.Size = 256;
		MetaUser.Instance.NormalizedUserName = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("ea0c7596-c0b8-4984-bc25-cb4b4857954e"), new System.Guid("8537ddb5-8ce2-4f35-a16f-207f2519ba9c"), new System.Guid("75ee3ec2-02bb-4666-a6f0-bac84c844dfa"));
		relationType.AssociationType.ObjectType = MetaUser.Instance;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "UserPasswordHash";
		relationType.RoleType.PluralName = "UserPasswordHashes";
		relationType.RoleType.Size = 256;
		MetaUser.Instance.UserPasswordHash = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("c1ae3652-5854-4b68-9890-a954067767fc"), new System.Guid("111104a2-1181-4958-92f6-6528cef79af7"), new System.Guid("58e35754-91a9-4956-aa66-ca48d05c7042"));
		relationType.AssociationType.ObjectType = MetaUser.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "UserEmail";
		relationType.RoleType.PluralName = "UserEmails";
		relationType.RoleType.Size = 256;
		MetaUser.Instance.UserEmail = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("0b3b650b-fcd4-4475-b5c4-e2ee4f39b0be"), new System.Guid("c89a8e3f-6f76-41ac-b4dc-839f9080d917"), new System.Guid("1b1409b8-add7-494c-a895-002fc969ac7b"));
		relationType.AssociationType.ObjectType = MetaUser.Instance;
		relationType.Workspace = true;
		relationType.RoleType.ObjectType = MetaBoolean.Instance;
		relationType.RoleType.SingularName = "UserEmailConfirmed";
		relationType.RoleType.PluralName = "UserEmailConfirmeds";
		MetaUser.Instance.UserEmailConfirmed = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("b4c09bec-168f-4f05-8ec6-919d1a24ae96"), new System.Guid("3d05bc18-c205-424a-ab26-fec24eafbd78"), new System.Guid("484ecaae-3f39-451b-a689-a55601df6778"));
		relationType.AssociationType.ObjectType = MetaUser.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaTaskList.Instance;
		relationType.RoleType.SingularName = "TaskList";
		relationType.RoleType.PluralName = "TaskLists";
		MetaUser.Instance.TaskList = relationType.RoleType; 
	}
	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("bed34563-4ed8-4c6b-88d2-b4199e521d74"), new System.Guid("e678c2f8-5c66-4886-ad21-2be98101f759"), new System.Guid("79e9a907-9237-4aab-9340-277d593748f5"));
		relationType.AssociationType.ObjectType = MetaUser.Instance;
		relationType.Workspace = true;
		relationType.AssignedMultiplicity = Allors.Multiplicity.OneToOne;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaNotificationList.Instance;
		relationType.RoleType.SingularName = "NotificationList";
		relationType.RoleType.PluralName = "NotificationLists";
		MetaUser.Instance.NotificationList = relationType.RoleType; 
	}
	}


	private void BuildRolesWorkItem() {

	{
		var relationType = new RelationType(this.metaPopulation, new System.Guid("7e6d392b-00e7-4095-8525-d9f4ef8cfaa3"), new System.Guid("b20f1b54-87a4-4fc2-91db-8848d6d40ad1"), new System.Guid("cf456f4d-8c76-4bfe-9996-89b660c9b153"));
		relationType.AssociationType.ObjectType = MetaWorkItem.Instance;
		relationType.Workspace = true;
		relationType.IsDerived = true;
		relationType.IsIndexed = true;
		relationType.RoleType.ObjectType = MetaString.Instance;
		relationType.RoleType.SingularName = "WorkItemDescription";
		relationType.RoleType.PluralName = "WorkItemDescriptions";
		relationType.RoleType.Size = -1;
		MetaWorkItem.Instance.WorkItemDescription = relationType.RoleType; 
	}
	}


		internal void BuildInheritedRoles()
		{
            MetaEnumeration.Instance.DeniedPermissions = MetaAccessControlledObject.Instance.DeniedPermissions;
            MetaEnumeration.Instance.SecurityTokens = MetaAccessControlledObject.Instance.SecurityTokens;
            MetaEnumeration.Instance.UniqueId = MetaUniquelyIdentifiable.Instance.UniqueId;

            MetaVersion.Instance.DeniedPermissions = MetaAccessControlledObject.Instance.DeniedPermissions;
            MetaVersion.Instance.SecurityTokens = MetaAccessControlledObject.Instance.SecurityTokens;



            MetaDelegatedAccessControlledObject.Instance.DeniedPermissions = MetaAccessControlledObject.Instance.DeniedPermissions;
            MetaDelegatedAccessControlledObject.Instance.SecurityTokens = MetaAccessControlledObject.Instance.SecurityTokens;

            MetaObjectState.Instance.UniqueId = MetaUniquelyIdentifiable.Instance.UniqueId;
            MetaTask.Instance.DeniedPermissions = MetaAccessControlledObject.Instance.DeniedPermissions;
            MetaTask.Instance.SecurityTokens = MetaAccessControlledObject.Instance.SecurityTokens;
            MetaTask.Instance.UniqueId = MetaUniquelyIdentifiable.Instance.UniqueId;
            MetaTransitional.Instance.DeniedPermissions = MetaAccessControlledObject.Instance.DeniedPermissions;
            MetaTransitional.Instance.SecurityTokens = MetaAccessControlledObject.Instance.SecurityTokens;
            MetaTransitionalVersion.Instance.DeniedPermissions = MetaAccessControlledObject.Instance.DeniedPermissions;
            MetaTransitionalVersion.Instance.SecurityTokens = MetaAccessControlledObject.Instance.SecurityTokens;
            MetaUser.Instance.OwnerSecurityToken = MetaSecurityTokenOwner.Instance.OwnerSecurityToken;
            MetaUser.Instance.OwnerAccessControl = MetaSecurityTokenOwner.Instance.OwnerAccessControl;
            MetaUser.Instance.DeniedPermissions = MetaAccessControlledObject.Instance.DeniedPermissions;
            MetaUser.Instance.SecurityTokens = MetaAccessControlledObject.Instance.SecurityTokens;

		}

		internal void BuildImplementedRoles()
		{
            MetaEmployment.Instance.DeniedPermissions = MetaEmployment.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaEmployment.Instance.SecurityTokens = MetaEmployment.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaOrganisation.Instance.DeniedPermissions = MetaOrganisation.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaOrganisation.Instance.SecurityTokens = MetaOrganisation.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaOrganisation.Instance.Locale = MetaOrganisation.Instance.Class.ConcreteRoleTypeByRoleType[MetaLocalised.Instance.Locale];
            MetaPerson.Instance.UserEmailConfirmed = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.UserEmailConfirmed];
            MetaPerson.Instance.UserName = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.UserName];
            MetaPerson.Instance.NormalizedUserName = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.NormalizedUserName];
            MetaPerson.Instance.UserEmail = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.UserEmail];
            MetaPerson.Instance.UserPasswordHash = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.UserPasswordHash];
            MetaPerson.Instance.TaskList = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.TaskList];
            MetaPerson.Instance.NotificationList = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.NotificationList];
            MetaPerson.Instance.OwnerSecurityToken = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaSecurityTokenOwner.Instance.OwnerSecurityToken];
            MetaPerson.Instance.OwnerAccessControl = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaSecurityTokenOwner.Instance.OwnerAccessControl];
            MetaPerson.Instance.DeniedPermissions = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaPerson.Instance.SecurityTokens = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaPerson.Instance.UniqueId = MetaPerson.Instance.Class.ConcreteRoleTypeByRoleType[MetaUniquelyIdentifiable.Instance.UniqueId];

            MetaSingleton.Instance.DeniedPermissions = MetaSingleton.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaSingleton.Instance.SecurityTokens = MetaSingleton.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaCounter.Instance.UniqueId = MetaCounter.Instance.Class.ConcreteRoleTypeByRoleType[MetaUniquelyIdentifiable.Instance.UniqueId];
            MetaMedia.Instance.UniqueId = MetaMedia.Instance.Class.ConcreteRoleTypeByRoleType[MetaUniquelyIdentifiable.Instance.UniqueId];
            MetaMedia.Instance.DeniedPermissions = MetaMedia.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaMedia.Instance.SecurityTokens = MetaMedia.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaMediaContent.Instance.DeniedPermissions = MetaMediaContent.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaMediaContent.Instance.SecurityTokens = MetaMediaContent.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaTemplate.Instance.UniqueId = MetaTemplate.Instance.Class.ConcreteRoleTypeByRoleType[MetaUniquelyIdentifiable.Instance.UniqueId];
            MetaTemplate.Instance.DeniedPermissions = MetaTemplate.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaTemplate.Instance.SecurityTokens = MetaTemplate.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaTemplateType.Instance.UniqueId = MetaTemplateType.Instance.Class.ConcreteRoleTypeByRoleType[MetaUniquelyIdentifiable.Instance.UniqueId];
            MetaTemplateType.Instance.DeniedPermissions = MetaTemplateType.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaTemplateType.Instance.SecurityTokens = MetaTemplateType.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaTemplateType.Instance.Name = MetaTemplateType.Instance.Class.ConcreteRoleTypeByRoleType[MetaEnumeration.Instance.Name];
            MetaTemplateType.Instance.LocalisedNames = MetaTemplateType.Instance.Class.ConcreteRoleTypeByRoleType[MetaEnumeration.Instance.LocalisedNames];
            MetaTemplateType.Instance.IsActive = MetaTemplateType.Instance.Class.ConcreteRoleTypeByRoleType[MetaEnumeration.Instance.IsActive];
            MetaPreparedExtent.Instance.UniqueId = MetaPreparedExtent.Instance.Class.ConcreteRoleTypeByRoleType[MetaUniquelyIdentifiable.Instance.UniqueId];
            MetaPreparedFetch.Instance.UniqueId = MetaPreparedFetch.Instance.Class.ConcreteRoleTypeByRoleType[MetaUniquelyIdentifiable.Instance.UniqueId];
            MetaCountry.Instance.DeniedPermissions = MetaCountry.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaCountry.Instance.SecurityTokens = MetaCountry.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaCurrency.Instance.DeniedPermissions = MetaCurrency.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaCurrency.Instance.SecurityTokens = MetaCurrency.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaCurrency.Instance.UniqueId = MetaCurrency.Instance.Class.ConcreteRoleTypeByRoleType[MetaUniquelyIdentifiable.Instance.UniqueId];
            MetaCurrency.Instance.Name = MetaCurrency.Instance.Class.ConcreteRoleTypeByRoleType[MetaEnumeration.Instance.Name];
            MetaCurrency.Instance.LocalisedNames = MetaCurrency.Instance.Class.ConcreteRoleTypeByRoleType[MetaEnumeration.Instance.LocalisedNames];
            MetaCurrency.Instance.IsActive = MetaCurrency.Instance.Class.ConcreteRoleTypeByRoleType[MetaEnumeration.Instance.IsActive];
            MetaLanguage.Instance.DeniedPermissions = MetaLanguage.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaLanguage.Instance.SecurityTokens = MetaLanguage.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaLocale.Instance.DeniedPermissions = MetaLocale.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaLocale.Instance.SecurityTokens = MetaLocale.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaLocalisedText.Instance.DeniedPermissions = MetaLocalisedText.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaLocalisedText.Instance.SecurityTokens = MetaLocalisedText.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaLocalisedText.Instance.Locale = MetaLocalisedText.Instance.Class.ConcreteRoleTypeByRoleType[MetaLocalised.Instance.Locale];
            MetaAccessControl.Instance.DeniedPermissions = MetaAccessControl.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaAccessControl.Instance.SecurityTokens = MetaAccessControl.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaAccessControl.Instance.CacheId = MetaAccessControl.Instance.Class.ConcreteRoleTypeByRoleType[MetaCachable.Instance.CacheId];

            MetaPermission.Instance.DeniedPermissions = MetaPermission.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaPermission.Instance.SecurityTokens = MetaPermission.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaRole.Instance.DeniedPermissions = MetaRole.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaRole.Instance.SecurityTokens = MetaRole.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaRole.Instance.UniqueId = MetaRole.Instance.Class.ConcreteRoleTypeByRoleType[MetaUniquelyIdentifiable.Instance.UniqueId];

            MetaAutomatedAgent.Instance.OwnerSecurityToken = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaSecurityTokenOwner.Instance.OwnerSecurityToken];
            MetaAutomatedAgent.Instance.OwnerAccessControl = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaSecurityTokenOwner.Instance.OwnerAccessControl];
            MetaAutomatedAgent.Instance.UserEmailConfirmed = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.UserEmailConfirmed];
            MetaAutomatedAgent.Instance.UserName = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.UserName];
            MetaAutomatedAgent.Instance.NormalizedUserName = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.NormalizedUserName];
            MetaAutomatedAgent.Instance.UserEmail = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.UserEmail];
            MetaAutomatedAgent.Instance.UserPasswordHash = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.UserPasswordHash];
            MetaAutomatedAgent.Instance.TaskList = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.TaskList];
            MetaAutomatedAgent.Instance.NotificationList = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaUser.Instance.NotificationList];
            MetaAutomatedAgent.Instance.DeniedPermissions = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaAutomatedAgent.Instance.SecurityTokens = MetaAutomatedAgent.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];

            MetaNotification.Instance.DeniedPermissions = MetaNotification.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaNotification.Instance.SecurityTokens = MetaNotification.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaNotificationList.Instance.DeniedPermissions = MetaNotificationList.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaNotificationList.Instance.SecurityTokens = MetaNotificationList.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
            MetaTaskAssignment.Instance.DeniedPermissions = MetaTaskAssignment.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaTaskAssignment.Instance.SecurityTokens = MetaTaskAssignment.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];

            MetaUserGroup.Instance.UniqueId = MetaUserGroup.Instance.Class.ConcreteRoleTypeByRoleType[MetaUniquelyIdentifiable.Instance.UniqueId];
            MetaUserGroup.Instance.DeniedPermissions = MetaUserGroup.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.DeniedPermissions];
            MetaUserGroup.Instance.SecurityTokens = MetaUserGroup.Instance.Class.ConcreteRoleTypeByRoleType[MetaAccessControlledObject.Instance.SecurityTokens];
		}

		internal void BuildAssociations()
		{
            MetaOrganisation.Instance.EmploymentsWhereEmployer = MetaEmployment.Instance.Employer.AssociationType;
            MetaPerson.Instance.EmploymentsWhereEmployee = MetaEmployment.Instance.Employee.AssociationType;
            MetaPerson.Instance.OrganisationWhereCurrentEmployee = MetaOrganisation.Instance.CurrentEmployees.AssociationType;
            MetaPerson.Instance.OrganisationsWhereFormerEmployee = MetaOrganisation.Instance.FormerEmployees.AssociationType;
            MetaPerson.Instance.TasksWhereParticipant = MetaTask.Instance.Participants.AssociationType;
            MetaPerson.Instance.TasksWherePerformer = MetaTask.Instance.Performer.AssociationType;
            MetaSettings.Instance.SingletonWhereSettings = MetaSingleton.Instance.Settings.AssociationType;

            MetaCounter.Instance.SettingsWhereCounter = MetaSettings.Instance.Counter.AssociationType;
            MetaMedia.Instance.PersonWherePicture = MetaPerson.Instance.Picture.AssociationType;
            MetaMedia.Instance.SingletonsWhereLogoImage = MetaSingleton.Instance.LogoImage.AssociationType;
            MetaMedia.Instance.TemplateWhereMedia = MetaTemplate.Instance.Media.AssociationType;
            MetaMediaContent.Instance.MediaWhereMediaContent = MetaMedia.Instance.MediaContent.AssociationType;

            MetaTemplateType.Instance.TemplatesWhereTemplateType = MetaTemplate.Instance.TemplateType.AssociationType;


            MetaCountry.Instance.LocalesWhereCountry = MetaLocale.Instance.Country.AssociationType;
            MetaCurrency.Instance.CountriesWhereCurrency = MetaCountry.Instance.Currency.AssociationType;
            MetaLanguage.Instance.LocalesWhereLanguage = MetaLocale.Instance.Language.AssociationType;
            MetaLocale.Instance.SingletonsWhereDefaultLocale = MetaSingleton.Instance.DefaultLocale.AssociationType;
            MetaLocale.Instance.SingletonWhereAdditionalLocale = MetaSingleton.Instance.AdditionalLocales.AssociationType;
            MetaLocale.Instance.LocalisedsWhereLocale = MetaLocalised.Instance.Locale.AssociationType;
            MetaLocalisedText.Instance.CountryWhereLocalisedName = MetaCountry.Instance.LocalisedNames.AssociationType;
            MetaLocalisedText.Instance.LanguageWhereLocalisedName = MetaLanguage.Instance.LocalisedNames.AssociationType;
            MetaLocalisedText.Instance.EnumerationWhereLocalisedName = MetaEnumeration.Instance.LocalisedNames.AssociationType;
            MetaAccessControl.Instance.SingletonWhereCreatorsAccessControl = MetaSingleton.Instance.CreatorsAccessControl.AssociationType;
            MetaAccessControl.Instance.SingletonWhereGuestAccessControl = MetaSingleton.Instance.GuestAccessControl.AssociationType;
            MetaAccessControl.Instance.SingletonWhereAdministratorsAccessControl = MetaSingleton.Instance.AdministratorsAccessControl.AssociationType;
            MetaAccessControl.Instance.SecurityTokensWhereAccessControl = MetaSecurityToken.Instance.AccessControls.AssociationType;
            MetaAccessControl.Instance.SecurityTokenOwnerWhereOwnerAccessControl = MetaSecurityTokenOwner.Instance.OwnerAccessControl.AssociationType;

            MetaPermission.Instance.AccessControlsWhereEffectivePermission = MetaAccessControl.Instance.EffectivePermissions.AssociationType;
            MetaPermission.Instance.RolesWherePermission = MetaRole.Instance.Permissions.AssociationType;
            MetaPermission.Instance.AccessControlledObjectsWhereDeniedPermission = MetaAccessControlledObject.Instance.DeniedPermissions.AssociationType;
            MetaPermission.Instance.ObjectStatesWhereDeniedPermission = MetaObjectState.Instance.DeniedPermissions.AssociationType;
            MetaRole.Instance.AccessControlsWhereRole = MetaAccessControl.Instance.Role.AssociationType;
            MetaSecurityToken.Instance.SingletonsWhereAdministratorSecurityToken = MetaSingleton.Instance.AdministratorSecurityToken.AssociationType;
            MetaSecurityToken.Instance.SingletonsWhereInitialSecurityToken = MetaSingleton.Instance.InitialSecurityToken.AssociationType;
            MetaSecurityToken.Instance.SingletonsWhereDefaultSecurityToken = MetaSingleton.Instance.DefaultSecurityToken.AssociationType;
            MetaSecurityToken.Instance.AccessControlledObjectsWhereSecurityToken = MetaAccessControlledObject.Instance.SecurityTokens.AssociationType;
            MetaSecurityToken.Instance.SecurityTokenOwnerWhereOwnerSecurityToken = MetaSecurityTokenOwner.Instance.OwnerSecurityToken.AssociationType;


            MetaNotification.Instance.NotificationListWhereNotification = MetaNotificationList.Instance.Notifications.AssociationType;
            MetaNotification.Instance.NotificationListWhereUnconfirmedNotification = MetaNotificationList.Instance.UnconfirmedNotifications.AssociationType;
            MetaNotification.Instance.NotificationListWhereConfirmedNotification = MetaNotificationList.Instance.ConfirmedNotifications.AssociationType;
            MetaNotification.Instance.TaskAssignmentWhereNotification = MetaTaskAssignment.Instance.Notification.AssociationType;
            MetaNotificationList.Instance.UserWhereNotificationList = MetaUser.Instance.NotificationList.AssociationType;
            MetaTaskAssignment.Instance.TaskListWhereTaskAssignment = MetaTaskList.Instance.TaskAssignments.AssociationType;
            MetaTaskAssignment.Instance.TaskListWhereOpenTaskAssignment = MetaTaskList.Instance.OpenTaskAssignments.AssociationType;
            MetaTaskList.Instance.UserWhereTaskList = MetaUser.Instance.TaskList.AssociationType;
            MetaUserGroup.Instance.AccessControlsWhereSubjectGroup = MetaAccessControl.Instance.SubjectGroups.AssociationType;




            MetaUniquelyIdentifiable.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;






            MetaObjectState.Instance.TransitionalsWherePreviousObjectState = MetaTransitional.Instance.PreviousObjectStates.AssociationType;
            MetaObjectState.Instance.TransitionalsWhereLastObjectState = MetaTransitional.Instance.LastObjectStates.AssociationType;
            MetaObjectState.Instance.TransitionalsWhereObjectState = MetaTransitional.Instance.ObjectStates.AssociationType;
            MetaObjectState.Instance.TransitionalVersionsWherePreviousObjectState = MetaTransitionalVersion.Instance.PreviousObjectStates.AssociationType;
            MetaObjectState.Instance.TransitionalVersionsWhereLastObjectState = MetaTransitionalVersion.Instance.LastObjectStates.AssociationType;
            MetaObjectState.Instance.TransitionalVersionsWhereObjectState = MetaTransitionalVersion.Instance.ObjectStates.AssociationType;
            MetaTask.Instance.TaskAssignmentsWhereTask = MetaTaskAssignment.Instance.Task.AssociationType;


            MetaUser.Instance.SingletonWhereGuest = MetaSingleton.Instance.Guest.AssociationType;
            MetaUser.Instance.AccessControlsWhereSubject = MetaAccessControl.Instance.Subjects.AssociationType;
            MetaUser.Instance.AccessControlsWhereEffectiveUser = MetaAccessControl.Instance.EffectiveUsers.AssociationType;
            MetaUser.Instance.LoginsWhereUser = MetaLogin.Instance.User.AssociationType;
            MetaUser.Instance.EmailMessagesWhereSender = MetaEmailMessage.Instance.Sender.AssociationType;
            MetaUser.Instance.EmailMessagesWhereRecipient = MetaEmailMessage.Instance.Recipients.AssociationType;
            MetaUser.Instance.TaskAssignmentsWhereUser = MetaTaskAssignment.Instance.User.AssociationType;
            MetaUser.Instance.UserGroupsWhereMember = MetaUserGroup.Instance.Members.AssociationType;
            MetaWorkItem.Instance.TasksWhereWorkItem = MetaTask.Instance.WorkItem.AssociationType;
		}

		internal void BuildInheritedAssociations()
		{
            MetaPerson.Instance.SingletonWhereGuest = MetaSingleton.Instance.Guest.AssociationType;
            MetaPerson.Instance.AccessControlsWhereSubject = MetaAccessControl.Instance.Subjects.AssociationType;
            MetaPerson.Instance.AccessControlsWhereEffectiveUser = MetaAccessControl.Instance.EffectiveUsers.AssociationType;
            MetaPerson.Instance.LoginsWhereUser = MetaLogin.Instance.User.AssociationType;
            MetaPerson.Instance.EmailMessagesWhereSender = MetaEmailMessage.Instance.Sender.AssociationType;
            MetaPerson.Instance.EmailMessagesWhereRecipient = MetaEmailMessage.Instance.Recipients.AssociationType;
            MetaPerson.Instance.TaskAssignmentsWhereUser = MetaTaskAssignment.Instance.User.AssociationType;
            MetaPerson.Instance.UserGroupsWhereMember = MetaUserGroup.Instance.Members.AssociationType;
            MetaPerson.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;


            MetaCounter.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;
            MetaMedia.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;

            MetaTemplate.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;
            MetaTemplateType.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;
            MetaPreparedExtent.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;
            MetaPreparedFetch.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;

            MetaCurrency.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;






            MetaRole.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;

            MetaAutomatedAgent.Instance.SingletonWhereGuest = MetaSingleton.Instance.Guest.AssociationType;
            MetaAutomatedAgent.Instance.AccessControlsWhereSubject = MetaAccessControl.Instance.Subjects.AssociationType;
            MetaAutomatedAgent.Instance.AccessControlsWhereEffectiveUser = MetaAccessControl.Instance.EffectiveUsers.AssociationType;
            MetaAutomatedAgent.Instance.LoginsWhereUser = MetaLogin.Instance.User.AssociationType;
            MetaAutomatedAgent.Instance.EmailMessagesWhereSender = MetaEmailMessage.Instance.Sender.AssociationType;
            MetaAutomatedAgent.Instance.EmailMessagesWhereRecipient = MetaEmailMessage.Instance.Recipients.AssociationType;
            MetaAutomatedAgent.Instance.TaskAssignmentsWhereUser = MetaTaskAssignment.Instance.User.AssociationType;
            MetaAutomatedAgent.Instance.UserGroupsWhereMember = MetaUserGroup.Instance.Members.AssociationType;





            MetaUserGroup.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;



            MetaEnumeration.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;







            MetaObjectState.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;
            MetaTask.Instance.NotificationsWhereTarget = MetaNotification.Instance.Target.AssociationType;




		}

		internal void BuildDefinedMethods()
		{
			{
				var method = new MethodType(this.metaPopulation, new System.Guid("FDD32313-CF62-4166-9167-EF90BE3A3C75"));
				method.ObjectType = MetaObject.Instance;
				method.Name = "OnBuild";
				MetaObject.Instance.OnBuild = method; 
			}
			{
				var method = new MethodType(this.metaPopulation, new System.Guid("2B827E22-155D-4AA8-BA9F-46A64D7C79C8"));
				method.ObjectType = MetaObject.Instance;
				method.Name = "OnPostBuild";
				MetaObject.Instance.OnPostBuild = method; 
			}
			{
				var method = new MethodType(this.metaPopulation, new System.Guid("B33F8EAE-17DC-4BF9-AFBB-E7FC38F42695"));
				method.ObjectType = MetaObject.Instance;
				method.Name = "OnPreDerive";
				MetaObject.Instance.OnPreDerive = method; 
			}
			{
				var method = new MethodType(this.metaPopulation, new System.Guid("C107F8B3-12DC-4FF9-8CBF-A7DEC046244F"));
				method.ObjectType = MetaObject.Instance;
				method.Name = "OnDerive";
				MetaObject.Instance.OnDerive = method; 
			}
			{
				var method = new MethodType(this.metaPopulation, new System.Guid("07AFF35D-F4CB-48FE-A39A-176B1931FAB7"));
				method.ObjectType = MetaObject.Instance;
				method.Name = "OnPostDerive";
				MetaObject.Instance.OnPostDerive = method; 
			}

			{
				var method = new MethodType(this.metaPopulation, new System.Guid("430702D2-E02B-45AD-9B22-B8331DC75A3F"));
				method.ObjectType = MetaDeletable.Instance;
				method.Name = "Delete";
				method.Workspace = true;
				MetaDeletable.Instance.Delete = method; 
			}






			{
				var method = new MethodType(this.metaPopulation, new System.Guid("C56B5BC5-35BD-4762-B237-54EA3BFC7E7A"));
				method.ObjectType = MetaDelegatedAccessControlledObject.Instance;
				method.Name = "DelegateAccess";
				MetaDelegatedAccessControlledObject.Instance.DelegateAccess = method; 
			}







		}

		internal void BuildInheritedMethods()
		{
				MetaEmployment.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaEmployment.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaEmployment.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaEmployment.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaEmployment.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaEmployment.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaOrganisation.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaOrganisation.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaOrganisation.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaOrganisation.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaOrganisation.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaOrganisation.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaPerson.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaPerson.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaPerson.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaPerson.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaPerson.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaPerson.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaSettings.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaSettings.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaSettings.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaSettings.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaSettings.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaSingleton.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaSingleton.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaSingleton.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaSingleton.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaSingleton.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaCounter.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaCounter.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaCounter.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaCounter.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaCounter.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaMedia.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaMedia.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaMedia.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaMedia.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaMedia.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaMedia.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaMediaContent.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaMediaContent.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaMediaContent.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaMediaContent.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaMediaContent.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaMediaContent.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaTemplate.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaTemplate.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaTemplate.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaTemplate.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaTemplate.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaTemplate.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaTemplateType.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaTemplateType.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaTemplateType.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaTemplateType.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaTemplateType.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaTemplateType.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaPreparedExtent.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaPreparedExtent.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaPreparedExtent.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaPreparedExtent.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaPreparedExtent.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaPreparedExtent.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaPreparedFetch.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaPreparedFetch.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaPreparedFetch.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaPreparedFetch.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaPreparedFetch.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaPreparedFetch.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaCountry.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaCountry.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaCountry.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaCountry.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaCountry.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaCurrency.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaCurrency.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaCurrency.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaCurrency.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaCurrency.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaLanguage.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaLanguage.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaLanguage.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaLanguage.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaLanguage.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaLocale.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaLocale.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaLocale.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaLocale.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaLocale.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaLocalisedText.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaLocalisedText.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaLocalisedText.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaLocalisedText.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaLocalisedText.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaLocalisedText.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaAccessControl.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaAccessControl.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaAccessControl.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaAccessControl.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaAccessControl.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaAccessControl.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaLogin.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaLogin.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaLogin.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaLogin.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaLogin.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaLogin.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaPermission.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaPermission.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaPermission.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaPermission.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaPermission.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaPermission.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaRole.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaRole.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaRole.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaRole.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaRole.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaSecurityToken.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaSecurityToken.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaSecurityToken.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaSecurityToken.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaSecurityToken.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaSecurityToken.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaAutomatedAgent.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaAutomatedAgent.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaAutomatedAgent.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaAutomatedAgent.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaAutomatedAgent.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaEmailMessage.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaEmailMessage.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaEmailMessage.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaEmailMessage.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaEmailMessage.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaNotification.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaNotification.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaNotification.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaNotification.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaNotification.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaNotificationList.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaNotificationList.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaNotificationList.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaNotificationList.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaNotificationList.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaNotificationList.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaTaskAssignment.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaTaskAssignment.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaTaskAssignment.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaTaskAssignment.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaTaskAssignment.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaTaskAssignment.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaTaskList.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaTaskList.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaTaskList.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaTaskList.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaTaskList.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;
				MetaTaskList.Instance.Delete = MetaDeletable.Instance.Delete;
				MetaUserGroup.Instance.OnBuild = MetaObject.Instance.OnBuild;
				MetaUserGroup.Instance.OnPostBuild = MetaObject.Instance.OnPostBuild;
				MetaUserGroup.Instance.OnPreDerive = MetaObject.Instance.OnPreDerive;
				MetaUserGroup.Instance.OnDerive = MetaObject.Instance.OnDerive;
				MetaUserGroup.Instance.OnPostDerive = MetaObject.Instance.OnPostDerive;

















		}

		internal void ExtendInterfaces()
		{
            MetaObject.Instance.Extend();
            MetaCachable.Instance.Extend();
            MetaDeletable.Instance.Extend();
            MetaEnumeration.Instance.Extend();
            MetaUniquelyIdentifiable.Instance.Extend();
            MetaVersion.Instance.Extend();
            MetaVersioned.Instance.Extend();
            MetaLocalised.Instance.Extend();
            MetaAccessControlledObject.Instance.Extend();
            MetaDelegatedAccessControlledObject.Instance.Extend();
            MetaSecurityTokenOwner.Instance.Extend();
            MetaObjectState.Instance.Extend();
            MetaTask.Instance.Extend();
            MetaTransitional.Instance.Extend();
            MetaTransitionalVersion.Instance.Extend();
            MetaUser.Instance.Extend();
            MetaWorkItem.Instance.Extend();
		}

		internal void ExtendClasses()
		{
            MetaEmployment.Instance.Extend();
            MetaOrganisation.Instance.Extend();
            MetaPerson.Instance.Extend();
            MetaSettings.Instance.Extend();
            MetaSingleton.Instance.Extend();
            MetaCounter.Instance.Extend();
            MetaMedia.Instance.Extend();
            MetaMediaContent.Instance.Extend();
            MetaTemplate.Instance.Extend();
            MetaTemplateType.Instance.Extend();
            MetaPreparedExtent.Instance.Extend();
            MetaPreparedFetch.Instance.Extend();
            MetaCountry.Instance.Extend();
            MetaCurrency.Instance.Extend();
            MetaLanguage.Instance.Extend();
            MetaLocale.Instance.Extend();
            MetaLocalisedText.Instance.Extend();
            MetaAccessControl.Instance.Extend();
            MetaLogin.Instance.Extend();
            MetaPermission.Instance.Extend();
            MetaRole.Instance.Extend();
            MetaSecurityToken.Instance.Extend();
            MetaAutomatedAgent.Instance.Extend();
            MetaEmailMessage.Instance.Extend();
            MetaNotification.Instance.Extend();
            MetaNotificationList.Instance.Extend();
            MetaTaskAssignment.Instance.Extend();
            MetaTaskList.Instance.Extend();
            MetaUserGroup.Instance.Extend();
		}
	}
}