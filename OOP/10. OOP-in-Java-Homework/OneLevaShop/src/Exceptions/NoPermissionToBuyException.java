package Exceptions;

public class NoPermissionToBuyException extends PurchaseException {
    public NoPermissionToBuyException(String message) {
        super(message);
    }
}