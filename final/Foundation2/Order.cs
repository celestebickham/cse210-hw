public class Order
{
    private List<Product> prod;
    private Customer cust;

    public Order(string name, string street, string city, string state, string country)
    {
        cust = new Customer();
        cust.SetCustomer(name, street, city, state, country);
        prod = new List<Product>();
    }

    public double ShipCost()
    {
        double shipCost = 0.00;
        if (cust.InUS() == true)
        {
            shipCost = 5.00;
        }
        else
        {
            shipCost = 35.00;
        }
        return shipCost;
    }

    public void AddProduct(Product product)
    {
        prod.Add(product);
    }

    public double TotalPrice()
    {
        double subTotal = 0;
        foreach (Product product in prod)
        {
            subTotal += product.GetQtyPrice();
        }
        double total = subTotal + ShipCost();
        return Math.Round(total, 2);
    }

    public string PackLabel()
    {
        string label = " ---- Packing Label ---- ";
        foreach (Product product in prod)
        {
            label += "\n" + product.GetProductName + " - ID: " + product.GetProductID;
        }
        return label;
    }

    public string ShipLabel()
    {
        string label = "\n ---- Shipping Label ---- \n";
        label += cust.CustomerName + "\n" + cust.Address;
        return label;
    }
}
//Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.

//The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.

//This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.

//A packing label should list the name and product id of each product in the order.

//A shipping label should list the name and address of the customer