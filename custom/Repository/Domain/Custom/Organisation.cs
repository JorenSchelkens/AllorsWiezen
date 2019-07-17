namespace Allors.Repository
{
    using Attributes;

    #region Allors
    [Id("3a5dcec7-308f-48c7-afee-35d38415aa0b")]
    #endregion
    public partial class Organisation : AccessControlledObject, Localised, Deletable
    {
        #region inherited properties
        public Permission[] DeniedPermissions { get; set; }

        public SecurityToken[] SecurityTokens { get; set; }

        public Locale Locale { get; set; }
        #endregion

        #region Allors
        [Id("2cc74901-cda5-4185-bcd8-d51c745a8437")]
        [AssociationId("896a4589-4caf-4cd2-8365-c4200b12f519")]
        [RoleId("baa30557-79ff-406d-b374-9d32519b2de7")]
        #endregion
        [Indexed]
        [Required]
        [Size(256)]
        [Workspace]
        public string Name { get; set; }

        #region Allors
        [Id("FEEA239C-D356-4732-9C7B-DCAC1BD9A237")]
        [AssociationId("708D8F20-2CB9-4A39-A476-E8920AFAC6F7")]
        [RoleId("5EFC6B5F-2850-49E8-814A-E29AE567E69B")]
        [Indexed]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Derived]
        [Workspace]
        public Person[] CurrentEmployees { get; set; }

        #region Allors
        [Id("A56B4D52-90CB-4A21-B7C1-58F0F7132D13")]
        [AssociationId("E2200A6C-B561-4579-A6A9-824FE079A973")]
        [RoleId("8813DE45-D779-4E82-816E-C86CFC617CEE")]
        [Indexed]
        #endregion
        [Multiplicity(Multiplicity.ManyToMany)]
        [Derived]
        [Workspace]
        public Person[] FormerEmployees { get; set; }

        #region inherited methods

        public void OnBuild() { }

        public void OnPostBuild() { }

        public void OnInit() { }

        public void OnPreDerive() { }

        public void OnDerive() { }

        public void OnPostDerive() { }

        public void Delete() { }
        #endregion
    }
}