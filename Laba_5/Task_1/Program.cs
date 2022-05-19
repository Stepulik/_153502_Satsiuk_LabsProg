using _5;

Potreblenye potreblenye = new Potreblenye();

    potreblenye.addTar("voda", 130);
    potreblenye.addTar("elektr", 1500);
    potreblenye.addTar("otoplenye", 500);
    potreblenye.addTar("gas", 50000);
    potreblenye.AddUser("SAM");
    potreblenye.AddUser("JACK");

    potreblenye.login("SAM");
    potreblenye.BuyTarifes("voda");
    potreblenye.BuyTarifes("otoplenye");
    potreblenye.logout();

    potreblenye.login("JACK");
    potreblenye.BuyTarifes("elektr");
    potreblenye.BuyTarifes("gas");
    potreblenye.logout();

    Console.WriteLine(potreblenye.GetTarifesByName("SAM"));
    Console.WriteLine(potreblenye.GetTarifesByName("JACK"));
    Console.WriteLine("total: "); 
    Console.WriteLine(potreblenye.GetTotalSum());