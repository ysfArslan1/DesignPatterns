
using TASARIMKALIPLARI.BuilderPattern;

namespace TASARIMKALIPLARI.BuilderPattern.Builder2
{

    public interface IOrderBuilder2
    {
        Order BuildOrder();
        void SetOrderPhone(string text);
        void  SetOrderAddress(string text);
        void  SetOrderEmail(string text);
        void  SetOrderUserName(string text);
        void  SetOrderProductIdList(List<string> _list);

    }
    public abstract class OrderBuilder2:IOrderBuilder2
    {
        protected Order order {get; set;}

        public OrderBuilder2(){
            order = new Order();
        }

        public abstract  void SetOrderPhone(string text);

        public  abstract  void  SetOrderAddress(string text);

        public  abstract  void  SetOrderEmail(string text);

        public  abstract  void  SetOrderUserName(string text);

        public  abstract  void  SetOrderProductIdList(List<string> _list);

        public Order BuildOrder(){
            return order;
        }

    }
}

