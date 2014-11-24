package Exceptions;

public class ProductOutOfStockException extends PurchaseException {
    public ProductOutOfStockException(String message) {
        super(message);
    }
}