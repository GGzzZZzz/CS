package Exceptions;

public class ProductExpiredException extends PurchaseException {
    public ProductExpiredException(String message) {
        super(message);
    }
}