
namespace TASARIMKALIPLARI.BuilderPattern.Builder1{
    public class OrderBuilder1{
        protected Order order {get; set;}

        public OrderBuilder1(){
            order = new Order();
        }

        public OrderBuilder1 SetOrderPhone(string text){
            order.phone = text;
            return this;
        }

        public OrderBuilder1 SetOrderAddress(string text){
            order.address = text;
            return this;
        }

        public OrderBuilder1 SetOrderEmail(string text){
            order.email = text;
            return this;
        }

        public OrderBuilder1 SetOrderUserName(string text){
            order.userName = text;
            return this;
        }

        public OrderBuilder1 SetOrderProductIdList(List<string> _list){
            order.productIdList = _list;
            return this;
        }

        public Order BuildOrder(){
            return order;
        }

    }
}

