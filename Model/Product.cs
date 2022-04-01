class Product {
    
    private String id;
    private String name;
    private int qty;

    private int price;

    public Product(){
        this.id="";
        this.name="";
        this.qty = 0;
        this.price = 0;
    }
    public Product(String id, String name, int qty, int price){
        this.id = id;
        this.name = name;
        this.qty = qty;
        this.price = price;
    }

    public bool CheckQty(int cQty){
        return cQty >= this.qty;
    }

    public bool checkId(String id){
        return id == this.id;
    }
}