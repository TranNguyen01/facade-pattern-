public class ShopFacede {
    private static ShopFacede instance = new ShopFacede();

    private AccountService accountService;
    private NotificationService notificationService;
    private PaymentService paymentService;
    private ShipingService shipingService;

    private ProductService productService;
    private ShopFacede(){
        accountService = new AccountService();
        notificationService = new NotificationService();
        paymentService = new PaymentService();
        shipingService = new ShipingService();
        productService = new ProductService();
    }

    public static ShopFacede getInstance(){
        return instance;
    }

    public void byProductByCashWithFreeShiping(String email, String product){
        Console.ForegroundColor = ConsoleColor.Blue;
        accountService.getAccount(email);
        productService.CheckQuantity(product);
        paymentService.paymentByCash();   
        shipingService.freeShiping();
        notificationService.sendEmail(email);   
        Console.ResetColor();
    }
}