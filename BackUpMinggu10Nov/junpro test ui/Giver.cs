namespace junpro_test_ui
{
    public class Giver : Account
    {
        private string location;
        private string aboutMe;

        // Constructor
        public Giver(string username, string password, string email, string role, string location, string aboutMe)
            : base(username, password, email, role)
        {
            this.location = location;
            this.aboutMe = aboutMe;
        }

        // Property untuk location
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        // Property untuk aboutMe
        public string AboutMe
        {
            get { return aboutMe; }
            set { aboutMe = value; }
        }
    }
}