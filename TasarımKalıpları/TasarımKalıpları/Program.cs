// See https://aka.ms/new-console-template for more information
using TASARIMKALIPLARI.BuilderPattern;
using TASARIMKALIPLARI.BuilderPattern.Builder1;
using TASARIMKALIPLARI.BuilderPattern.Builder2;

BuilderPatternExm();

// Builder Pattern
void BuilderPatternExm(){

    var orderBuilder = new OrderBuilder1();

    var order = orderBuilder.SetOrderPhone("05555555555")
                .SetOrderEmail("a@gmail.com")
                .SetOrderAddress("cad. block. no12")
                .SetOrderUserName("cem")
                .SetOrderProductIdList(new List<string>{"1","2","3"})
                .BuildOrder();

    System.Console.WriteLine("OrderBuilder1 // "+order.Aciklama());

    Order generateOrder (string phone, string email,string adress, string userName, List<string> idList, int orderType)
    {
        IOrderBuilder2 orderBuilder;
        if (orderType == 0)
            orderBuilder = new EmployeOrderBuilder2();
        else
            orderBuilder = new ExternalOrderBuilder2();

        orderBuilder.SetOrderPhone(phone);
        orderBuilder.SetOrderEmail(email);
        orderBuilder.SetOrderAddress(adress);
        orderBuilder.SetOrderUserName(userName);
        orderBuilder.SetOrderProductIdList(idList);
        return orderBuilder.BuildOrder();
    }
                
    var order1 = generateOrder("05555555555","a@gmail.com","cad. block. no12","cem",new List<string>{"1","2","3"},0);
    System.Console.WriteLine("EmployeOrderBuilder2 // "+order1.Aciklama());
                
    var order2 = generateOrder("05555555555","a@gmail.com","cad. block. no12","cem",new List<string>{"1","2","3"},1);
    System.Console.WriteLine("ExternalOrderBuilder2 // "+order2.Aciklama());

}
