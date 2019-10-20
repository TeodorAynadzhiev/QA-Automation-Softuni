namespace Homework
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                FirstName = "Teodor",
                LastName = "Aynadzhiev",
                Password = "123sad3q4",
                Date = "3",                
                Month = "3",
                Year = "1999",
                RealFirstName = "Teodor",
                RealLastName = "Aynadzhiev",
                Address = "Florida str 3",
                City = "Florida",
                State = "2",
                PostCode = "92503",
                Country = "21",
                Phone = "87657",
                Alias = "Home"
                
            };
        }
    }
}
