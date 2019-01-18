// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmploymentTests.cs" company="Allors bvba">
//   Copyright 2002-2009 Allors bvba.
// 
// Dual Licensed under
//   a) the General Public Licence v3 (GPL)
//   b) the Allors License
// 
// The GPL License is included in the file gpl.txt.
// The Allors License is an addendum to your contract.
// 
// Allors Platform is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// For more information visit http://www.allors.com/legal
// </copyright>
// <summary>
//   Defines the PersonTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Allors.Domain
{
    using System;

    using Xunit;

    public class EmploymentTests : DomainTest
    {
        [Fact]
        public void GivenEmployement_WhenDeriving_ThenCurrentEmployeesShouldBeUpdated()
        {
            var now = this.Session.Now();

            var acme = new OrganisationBuilder(this.Session).WithName("Acme").Build();
            var john = new PersonBuilder(this.Session).WithFirstName("John").WithLastName("Doe").Build();

            new EmploymentBuilder(this.Session).WithEmployer(acme).WithEmployee(john).WithFrom(now.Subtract(TimeSpan.FromDays(1))).Build();

            this.Session.Derive();
            this.Session.Commit();

            Assert.Single(acme.CurrentEmployees);
            Assert.Contains(john, acme.CurrentEmployees);
        }

        [Fact]
        public void GivenEmployement_WhenDeletingEmployee_ThenCurrentEmployeesShouldBeUpdated()
        {
            var now = this.Session.Now();

            var acme = new OrganisationBuilder(this.Session).WithName("Acme").Build();
            var john = new PersonBuilder(this.Session).WithFirstName("John").WithLastName("Doe").Build();

            new EmploymentBuilder(this.Session).WithEmployer(acme).WithEmployee(john).WithFrom(now.Subtract(TimeSpan.FromDays(1))).Build();

            this.Session.Derive();
            this.Session.Commit();

            john.Delete();

            this.Session.Derive();

            Assert.Empty(acme.CurrentEmployees);
        }
    }
}
