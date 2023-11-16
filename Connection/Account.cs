namespace LTUD1_MF_BHX.Connection
{
    internal class Account
    {
        private string username, password, userid;
        private DateTime createdDate;

        public Account()
        {
            userid = "123123123123";
            username = "admin";
            password = "password";
            createdDate = DateTime.Now;
        }
        public Account(string username, string password, string userid, DateTime createdDate)
        {
            this.username = username;
            this.password = password;
            this.userid = userid;
            this.createdDate = createdDate;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Userid { get => userid; set => userid = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
    }
}
