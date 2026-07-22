// Factory Method
Logistic logistic = new RoadLogistic();
Deliver(logistic, "Vaz 2107");
Deliver(new SeaLogistic(), "Vaza");



void Deliver(Logistic logistic, string productName)
{
    var transport = logistic.CreateTransport();
    transport.Delivery(productName);
}