namespace Allors.Repository
{
    using System;
    using Attributes;

    #region Allors
    [Id("DBDC5419-FF3D-4888-A7FF-089CA469CE54")]
    #endregion
    public partial class Employment : AccessControlledObject, Deletable
    {
        #region inherited properties
        public Permission[] DeniedPermissions { get; set; }

        public SecurityToken[] SecurityTokens { get; set; }
        #endregion

        #region Allors
        [Id("12AC77FF-5E0B-4E72-B9AE-8375CDD840DE")]
        [AssociationId("BCFC78B7-0075-4270-BB0F-C19AA398CE18")]
        [RoleId("8A7B367C-C0CD-4E8B-B169-4F9A400FC30E")]
        [Indexed]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Workspace]
        [Required]
        public Organisation Employer { get; set; }

        #region Allors
        [Id("35B8F4AD-E291-4ADB-B311-980BB1685BFD")]
        [AssociationId("25270F26-6F40-4D6D-AACD-BBC7D56DFD56")]
        [RoleId("9BA61F25-3547-4364-8C20-A7A68A05EC37")]
        [Indexed]
        #endregion
        [Required]
        [Multiplicity(Multiplicity.ManyToOne)]
        [Workspace]
        public Person Employee { get; set; }

        #region Allors
        [Id("28BD57B7-9653-45E0-A2BB-EE53A4F3642C")]
        [AssociationId("5A2EB977-C8AA-4723-A8F6-B048C54556C7")]
        [RoleId("5937A273-AC8A-43C1-8E8D-51035C351B69")]
        #endregion
        [Workspace]
        [Required]
        public DateTime From { get; set; }

        #region Allors
        [Id("A1495CB5-47D5-4D60-97F4-380BE9120865")]
        [AssociationId("E1423D7E-623A-4D68-B5B9-9E95A0EA5118")]
        [RoleId("8832FE15-CC92-42EA-B15C-DFFB6E228193")]
        #endregion
        [Workspace]
        public DateTime Through { get; set; }

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