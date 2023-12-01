
namespace TASARIMKALIPLARI.BuilderPattern.Builder2{
    public class ExternalOrderBuilder2 : OrderBuilder2
    {
        public override void SetOrderAddress(string text)
        {
            order.address = text;
        }

        public override void SetOrderEmail(string text)
        {
            order.email = text;
        }

        public override void SetOrderPhone(string text)
        {
            order.phone = text;
        }

        public override void SetOrderProductIdList(List<string> _list)
        {
            order.productIdList = _list;
        }

        public override void SetOrderUserName(string text)
        {
            order.userName = text;
        }
    }
}