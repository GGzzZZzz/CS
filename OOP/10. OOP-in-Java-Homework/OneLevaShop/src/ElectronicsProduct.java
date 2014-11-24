import java.math.BigDecimal;

public abstract class ElectronicsProduct extends Product {
    protected int guaranteePeriod;

    protected ElectronicsProduct(String name, BigDecimal price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);

    }


}
