namespace Allors.Repository
{
    using Attributes;

    #region Allors

    [Id("2755cb20-76af-4102-a5b9-83c21a90c532")]

    #endregion Allors
    public partial class Chat : Object
    {
        #region Allors
        [Id("5a26ba2c-3d82-4908-a2b5-9f89022f6af1")]
        [AssociationId("77e2ca1d-d89a-4a9d-a643-cdb96e3ae427")]
        [RoleId("8174444e-74f2-4174-9f41-b24d4439fc9e")]
        #endregion Allors
        [Size(200)]
        [Workspace]
        public string Name { get; set; }

        #region Allors
        [Id("1b2bc9c7-95a2-4308-bdb3-1cc5c402bed9")]
        [AssociationId("cc6ef1f7-be3d-4d60-a063-b5a49e9d3894")]
        [RoleId("d631576b-ef3c-4b93-972d-14c786994c6c")]
        #endregion Allors
        [Size(200)]
        [Workspace]
        public string Title { get; set; }

        #region Allors
        [Id("66e007ef-082b-4115-b771-3722d184452d")]
        [AssociationId("a46330d5-50ce-40f0-8109-9f1c63b23a14")]
        [RoleId("9109079d-695b-4a15-8ec5-788cb791ac4d")]
        #endregion Allors
        [Multiplicity(Multiplicity.ManyToMany)]
        [Derived]
        [Workspace]
        public Person[] Participants { get; set; }

        #region Allors
        [Id("892f049c-27bf-432b-943c-3e204e72438f")]
        [AssociationId("bcd17996-c46c-46e6-85c1-8bacceffc352")]
        [RoleId("b3140abd-3b16-400b-a00e-6a86090caeaa")]
        #endregion Allors
        [Multiplicity(Multiplicity.OneToMany)]
        [Workspace]
        public Message[] Messages { get; set; }


        #region Allors
        [Id("e3664a7d-42ab-479d-ab0f-737efbe69a1e")]
        [AssociationId("245d0d1a-c2c5-4a57-b524-f1edc0742fc6")]
        [RoleId("b6083e86-14bf-4b74-ab64-86c4cbbf0ea7")]
        #endregion Allors
        [Multiplicity(Multiplicity.OneToMany)]
        [Workspace]
        [Synced]
        public Statistic[] Statistics { get; set; }

        #region Inherited Methods
        public void OnBuild()
        {
        }

        public void OnDerive()
        {
        }

        public void OnInit()
        {
        }

        public void OnPostBuild()
        {
        }

        public void OnPostDerive()
        {
        }

        public void OnPreDerive()
        {
        }
        #endregion
    }
}