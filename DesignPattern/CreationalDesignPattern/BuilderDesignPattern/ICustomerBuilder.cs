namespace DesignPattern.BuilderDesignPattern
{
    public interface ICustomerBuilder
    {
        ICustomerBuilder FirstName(string firstName);
        ICustomerBuilder LastName(string lastName);
        ICustomerBuilder MiddleName(string middleName);
        ICustomerBuilder PrimaryEmail(string primaryEmail);
        ICustomerBuilder SecondaryEmail(string secondaryEmail);
        ICustomerBuilder PrimaryMobileNumber(string primaryMobileNumber);
        ICustomerBuilder SecondaryMobileNumber(string secondaryMobileNumber);
        Customer Build();
    }
}
