namespace junpro_test_ui
{
    class Receiver
    {
        public string Email;
        public string Password;

        public Receiver(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public bool LoginReceiver(string email, string password)
        {
            if (Email == "ella@gmail.com" && Password == "haha")
            {
                return true;
            }
            else if (Email == "bena@gmail.com" && Password == "hihi")
            {
                return true;
            }
            else { return false; }
        }
    }
}