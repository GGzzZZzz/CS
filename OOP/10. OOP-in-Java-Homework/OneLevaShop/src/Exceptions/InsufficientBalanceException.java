package Exceptions;

public class InsufficientBalanceException extends PurchaseException {

    public InsufficientBalanceException(String message) {
        super(message);
    }
}