import Exceptions.*;

public final class PurchaseManager {
    public static void ProcessPurchase(Customer customer, Product product) throws PurchaseException{
        if (product.getQuantity() < 1) {
            throw new ProductOutOfStockException("Product out of stock!");
        }

        if (product instanceof FoodProduct && ((FoodProduct) product).getHasExpired()) {
            throw new ProductExpiredException("This product has expired!");
        }

        if (customer.getBalance().compareTo(product.getPrice()) == -1) {
            throw new InsufficientBalanceException("You do not have enough money to buy this product!");
        }

        if(customer.getAge() < 18 && product.getAgeRestriction() == AgeRestriction.Adult){
            throw  new NoPermissionToBuyException("You are too young to buy this product!");
        }

        customer.setBalance(customer.getBalance().subtract(product.getPrice()));
        product.setQuantity(product.getQuantity()-1);
    }
}