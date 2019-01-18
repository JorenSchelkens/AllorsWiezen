namespace Allors.Domain
{
    public partial class Person
    {
        public void CustomDelete(DeletableDelete method)
        {
            foreach (Employment employment in this.EmploymentsWhereEmployee)
            {
                employment.Delete();
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
