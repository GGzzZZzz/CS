import Exceptions.PurchaseException;
import Interfaces.Expirable;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class ShopTest {
    public static void main(String[] args) {
        Product cigars = new FoodProduct(
                "420 Blaze it fgt",
                new BigDecimal(6.9),
                1400,
                AgeRestriction.Adult,
                "29/10/2014");

        Customer pecata = new Customer("Pecata", 17, new BigDecimal(30.00));

        try {
            PurchaseManager.ProcessPurchase(pecata, cigars);

        } catch (PurchaseException pe) {
            System.err.println(pe.getMessage());
        }


        Customer gopeto = new Customer("Gopeto", 18, new BigDecimal(0.44));

        try {
            PurchaseManager.ProcessPurchase(gopeto, cigars);

        } catch (PurchaseException pe) {
            System.err.println(pe.getMessage());

        }

        List<Product> products = new ArrayList<Product>();
        products.add(new FoodProduct("Biser oil", new BigDecimal(2.50), 2, AgeRestriction.None, "31/12/2014"));
        products.add(new FoodProduct("Luibimka medenka", new BigDecimal(0.50), 5, AgeRestriction.None, "31/12/2014"));
        products.add(new Computer("HP laptop", new BigDecimal(1000), 100, AgeRestriction.None));
        products.add(new Computer("Lenovo laptop", new BigDecimal(1520), 250, AgeRestriction.None));
        products.add(new Appliance("Casio calculator", new BigDecimal(10.30), 10, AgeRestriction.None));
        products.add(new Appliance("Casio watch", new BigDecimal(89.90), 3, AgeRestriction.None));

        Comparator<Product> compareByExpirationDate = (p1, p2) ->
                (((Expirable) p1).getExpirationDate()).compareTo(((Expirable) p2).getExpirationDate());
        Product expirable = products.stream()
                .filter(product -> product instanceof Expirable)
                .sorted(compareByExpirationDate)
                .findFirst()
                .get();

        Comparator<Product> compareByPrice = (p1, p2) -> p1.getPrice().compareTo(p2.getPrice());
        List<Product> adultsSortedByPrice = products.stream()
                .filter(product -> product.getAgeRestriction() == AgeRestriction.Adult)
                .sorted(compareByPrice)
                .collect(Collectors.toList());
    }
}