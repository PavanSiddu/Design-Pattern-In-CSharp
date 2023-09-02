namespace DesignPattern.BuilderDesignPattern
{
    public class CustomerBuilder : ICustomerBuilder
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string primaryEmail;
        private string secondaryEmail;
        private string primaryMobileNumber;
        private string secondaryMobileNumber;

        public ICustomerBuilder FirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public ICustomerBuilder LastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public ICustomerBuilder MiddleName(string middleName)
        {
            this.middleName = middleName;
            return this;
        }

        public ICustomerBuilder PrimaryEmail(string primaryEmail)
        {
            this.primaryEmail = primaryEmail;
            return this;
        }

        public ICustomerBuilder SecondaryEmail(string secondaryEmail)
        {
            this.secondaryEmail = secondaryEmail;
            return this;
        }

        public ICustomerBuilder PrimaryMobileNumber(string primaryMobileNumber)
        {
            this.primaryMobileNumber = primaryMobileNumber;
            return this;
        }

        public ICustomerBuilder SecondaryMobileNumber(string secondaryMobileNumber)
        {
            this.secondaryMobileNumber = secondaryMobileNumber;
            return this;
        }

        public Customer Build()
        {
            return new Customer(this);
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getMiddleName()
        {
            return middleName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getPrimaryEmail()
        {
            return primaryEmail;
        }

        public string getSecondaryEmail()
        {
            return secondaryEmail;
        }

        public string getPrimaryMobileNumber()
        {
            return primaryMobileNumber;
        }

        public string getSecondaryMobileNumber()
        {
            return secondaryMobileNumber;
        }
    }
}
