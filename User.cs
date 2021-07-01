namespace dll
{
    public class User
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string contact { get; set; }


        public User()
        {
        }

        public User(string temp1, string temp2, string temp3)
        {
            name = temp1;
            surName = temp2;
            contact = temp3;
        }
    }
}