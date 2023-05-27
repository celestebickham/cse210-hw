using System;

public class Product
{
    private int _productID;
    private string _productName;
    private double _productPrice;
    private int _productQuantity;

    public Product()
    {
        _productID = 0;
        _productName = "None";
        _productPrice = 0;
        _productQuantity = 0;
    }

    public Product(int ID, string Name, double Price, int Quantity)
    {
        _productID = ID;
        _productName = Name;
        _productPrice = Price;
        _productQuantity = Quantity;
    }

    public int GetProductID
    {
        get
        {
            return _productID;
        }
    }

    public string GetProductName
    {
        get
        {
            return _productName;
        }
    }

    public double GetProductPrice
    {
        get
        {
            return _productPrice;
        }
    }

    public int GetProductQuantity
    {
        get
        {
            return _productQuantity;
        }
    }

    public double GetQtyPrice()
    {
        double qtyPrice = _productQuantity * _productPrice;
        return qtyPrice;
    }

    public string GetFullProduct()
    {
        string completeProduct = $"{_productID} {_productName} {_productPrice} {_productQuantity}";
        return completeProduct;
    }
}

//Contains the name, product id, price, and quantity of each product.
//The price of this product is computed by multiplying the price and the quantity.