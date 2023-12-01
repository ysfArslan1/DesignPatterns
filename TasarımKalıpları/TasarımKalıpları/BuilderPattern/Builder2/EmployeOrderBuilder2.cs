

namespace TASARIMKALIPLARI.BuilderPattern.Builder2{
    public class EmployeOrderBuilder2 : OrderBuilder2
    {
        public override void SetOrderAddress(string text)
        {
            order.address = text + " City, Company";
        }

        public override void SetOrderEmail(string text)
        {
            var _email = text.Split("@");
            order.email = _email[0]+"@company.com.tr";
        }

        public override void SetOrderPhone(string text)
        {
            order.phone = text + ", 2222222222";
        }

        public override void SetOrderProductIdList(List<string> _list)
        {
            order.productIdList = _list;
        }

        public override void SetOrderUserName(string text)
        {
            order.userName = text+" Best Employe";
        }
    }
}

