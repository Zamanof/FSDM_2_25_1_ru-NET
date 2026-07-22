// Observer
// Also know as: Event-Subscriber, Listener

// Subject - Publisher
// Observer - Subscribers

ProductManager productManager = new ProductManager();
var customer = new Customer();

productManager.Attach(customer);
productManager.Attach(new Customer());
productManager.Attach(new Employee());

productManager.UpdatePrice();

productManager.Detach(customer);
Console.WriteLine();
productManager.UpdatePrice();


