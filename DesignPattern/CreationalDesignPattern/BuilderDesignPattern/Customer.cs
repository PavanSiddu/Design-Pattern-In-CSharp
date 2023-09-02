namespace DesignPattern.BuilderDesignPattern
{
    public class Customer
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string primaryEmail;
        private string secondaryEmail;
        private string primaryMobileNumber;
        private string secondaryMobileNumber;

        public Customer(CustomerBuilder customerBuilder)
        {
            this.firstName = customerBuilder.getFirstName();
            this.middleName = customerBuilder.getMiddleName();
            this.lastName = customerBuilder.getLastName();
            this.primaryEmail = customerBuilder.getPrimaryEmail();
            this.secondaryEmail = customerBuilder.getSecondaryEmail();
            this.primaryMobileNumber = customerBuilder.getPrimaryMobileNumber();
            this.secondaryMobileNumber = customerBuilder.getSecondaryMobileNumber();
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

        public string toString()
        {
            return "First Name: " + firstName + "\n" +
                    "Middle Name: " + middleName + "\n" +
                    "Last Name: " + lastName + "\n" +
                    "Primary Email: " + primaryEmail + "\n" +
                    "Secondary Email: " + secondaryEmail + "\n" +
                    "Primary Mobile Number: " + primaryMobileNumber + "\n" +
                    "Secondary Mobile Number: " + secondaryMobileNumber + "\n";
        }
    }
}
