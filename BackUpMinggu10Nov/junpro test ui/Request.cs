namespace junpro_test_ui
{
    class Request
    {
        public string Receiver;
        public string Quantities;

        public Request(string receiver, string quantities)
        {
            Receiver = receiver;
            Quantities = quantities;
        }

        public bool SentRequest(string receiver, string quantities)
        {
            if (Receiver == "Ella" && Quantities == "2")
            {
                return true;
            }
            else if (Receiver == "Fika" && Quantities == "1")
            {
                return true;
            }
            else { return false; }
        }
    }
}