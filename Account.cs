namespace junpro_test_ui
{
    class Account
    {
        public string RegisterName;
        public string Password;
        public string Email;
        public string NomorTelephone;
        public string Location;

        public Account(string registerName, string password, string email, string nomorTelephone, string location)
        {
            RegisterName = registerName;
            Password = password;
            Email = email;
            NomorTelephone = nomorTelephone;
            Location = location;
        }

        public bool Register(string registerName, string password, string email, string nomorTelephone, string location)
        {
            if (RegisterName == "Ella" && Password == "haha" && Email == "ella@gmail.com" &&  NomorTelephone == "081211223344" && Location == "Sleman")
            {
                return true;
            } else if (RegisterName == "Bena" && Password == "hihi" && Email == "bena@gmail.com" && NomorTelephone == "081299887766" && Location == "Jakarta")
            {
                return true;
            } else { return false; }
        }
    }
}