namespace BuilderPattern
{
    public class Order
    {
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public List<string> productIdList { get; set; }

        public string Aciklama()
        {
            return $"user name : {userName}, email : {email}, phane : {phone}, address : {address}";
        }

    }
}

