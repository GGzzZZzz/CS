package Exceptions;

public abstract class PurchaseException extends Exception {

    protected PurchaseException(String message) {
        super(message);
    }
}