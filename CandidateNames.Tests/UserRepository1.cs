using CandidateNames.Sources;

namespace CandidateNames.Tests
{
    public partial class CandidateHandlerTest
    {
        private class UserRepository1 : IUserRepository
        {
            public string[] GetDeveloperJobApplicants()
            {
                var applicants = new[]
                {
                    "Carrie, Kirker",
                    "Masako, Freas",
                    "Collins, Bill",
                    "Smith , Bart",
                    "Allen,  Tim",
                    "Courtney Tyrrell",
                    "Gidget, Borey",
                    "Holley, Witte",
                    "Robby,  Payeur",
                    "Deloise,, Carnegie",
                    "Sherwood ,Dille, Tim",
                    "Lea, Balfour",
                    "Catharine, Capra",
                    "Julian, Turman",
                };

                return applicants;
            }

            public string[] GetTesterJobApplicants()
            {
                var applicants = new[]
                {
                    "Deloise,, Carnegie",
                    "Sherwood ,Dille, Tim",
                    "Lea, Balfour",
                    "Catharine, Capra",
                    "Julian, Turman",
                    "Hoa ,Wissing",
                    "Shanika, Theriault",
                    "Eloise ,Fielden",
                    "Marylynn, Masterson",
                    "Hyun, Gonser",
                    "Sherlene , Tumlin",
                    "Harley , Delosreyes",
                    "Lillie, Stolp",
                    "Fred, Noblin",
                    "Tangela ,Leider",
                    "Long, Bruner",
                    "Gaynell, Jaquith",
                    "Karey, Whitworth",
                    "Arturo, Shanley"
                };

                return applicants;
            }
        }
    }
}
