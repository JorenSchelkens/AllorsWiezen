namespace Allors.Repository
{
    using Attributes;

    #region Allors
    [Id("DC94D0BF-E08D-4B01-A91F-723CED6F3C36")]
    #endregion
    [Plural("Setingses")]
    public partial class Settings : Object
    {
        #region Allors
        [Id("1A3BFB5A-10AE-4B95-B592-673D17B69018")]
        [AssociationId("03A8792D-7D7C-48D8-A9D4-85C20663CE5B")]
        [RoleId("0ABD5CA7-ABC4-4EC3-A148-F9BB1857DC70")]
        [Indexed]
        #endregion
        [Multiplicity(Multiplicity.OneToOne)]
        public Counter Counter { get; set; }

        #region Allors
        [Id("A74F8F8B-90C7-4A50-A3EB-A12449AA1066")]
        [AssociationId("B44031D6-E75A-4EDB-B683-ACAC7578749E")]
        [RoleId("C3376114-B34C-4F18-8C50-041F767B439E")]
        [Indexed]
        #endregion
        [Workspace]
        public string Setting { get; set; }

        #region inherited methods
        public void OnBuild() { }

        public void OnPostBuild() { }

        public void OnInit() { }

        public void OnPreDerive() { }

        public void OnDerive() { }

        public void OnPostDerive() { }

        #endregion
    }
}