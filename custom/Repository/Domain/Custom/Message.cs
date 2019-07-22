namespace Allors.Repository
{
    using Attributes;
    using System;

    #region Allors

    [Id("6ac5eaea-b2cc-48b7-8d94-fbe68c475975")]

    #endregion Allors
    public partial class Message : Object, Deletable
    {
        #region Allors
        [Id("88465c00-4966-4631-b1c0-52c9a7d018a1")]
        [AssociationId("d73e5371-a01d-4d1b-a001-bb79e87c9d38")]
        [RoleId("da6fcd4d-9985-445e-95e5-82166dd9d163")]
        #endregion Allors
        [Multiplicity(Multiplicity.ManyToOne)]
        [Workspace]
        public Person Author { get; set; }

        #region Allors
        [Id("e38757eb-d3ea-4882-9d99-6e3e33284352")]
        [AssociationId("3f53b13c-939a-416c-95bc-87b99d5364c3")]
        [RoleId("aa33ceeb-082b-41fe-9716-647b77902a02")]
        #endregion Allors
        [Size(-1)]
        [Workspace]
        public string Text { get; set; }

        #region Allors
        [Id("153282d2-450d-4aff-ab5d-88e70f647427")]
        [AssociationId("c5e96ab2-c3d9-45e9-8af7-eb4530197bdc")]
        [RoleId("b7645252-aa9f-41c2-8aad-cb3900e0c6ac")]
        #endregion Allors
        [Workspace]
        public DateTime Date { get; set; }

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