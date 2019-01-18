namespace Allors.Domain
{
    using System.Linq;

    public partial class Organisation
    {
        public void CustomOnDerive(ObjectOnDerive method)
        {
            var now = this.strategy.Session.Now();

            var employements = this.EmploymentsWhereEmployer.ToArray();

            this.CurrentEmployees = employements
                .Where(v => v.From < now && (!v.ExistThrough || v.Through > now))
                .Select(v => v.Employee)
                .ToArray();

            this.FormerEmployees = employements
                .Where(v => v.From < now && (!v.ExistThrough || v.Through > now))
                .Select(v => v.Employee)
                .ToArray();
        }

        public void BaseDelete(DeletableDelete method)
        {
            foreach (Employment employment in this.EmploymentsWhereEmployer)
            {
                employment.Delete();
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
