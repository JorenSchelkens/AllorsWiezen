namespace Allors.Repository
{
    using Attributes;

    #region Allors

    [Id("ab3770a3-e49d-4c97-a043-29345f71b680")]

    #endregion Allors
    public partial class Statistic : Object, Deletable
    {
        #region Allors
        [Id("9ff6018e-e416-4b50-b29d-ceee472e88d6")]
        [AssociationId("32fc9a36-ec6e-4447-b5ca-c7062c97ef6d")]
        [RoleId("8e9ace0f-1e22-468d-b06f-1ce1d06018c8")]
        #endregion Allors
        [Multiplicity(Multiplicity.ManyToOne)]
        [Synced]
        [Workspace]
        public Person Participant { get; set; }

        #region Allors
        [Id("13ced95a-82f6-4c2e-ae81-13019413d3f9")]
        [AssociationId("20d7dc6e-3aca-4a7f-a2f7-38c79d14b14b")]
        [RoleId("735b39ef-f1c3-4fa2-b4b3-a7275d410a71")]
        #endregion Allors
        [Derived]
        [Workspace]
        public int MessageCount { get; set; }

        #region Allors
        [Id("c81301ba-a7b1-4af9-8fc9-c160b0cac410")]
        [AssociationId("874e904b-3d00-42db-b0a9-3262904ac3a7")]
        [RoleId("0b30c6cd-de91-4268-94fc-59ccc367b6fc")]
        #endregion Allors
        [Derived]
        [Workspace]
        public int WordCount { get; set; }


        #region Inherited Methods

        public void Delete()
        {
        }

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