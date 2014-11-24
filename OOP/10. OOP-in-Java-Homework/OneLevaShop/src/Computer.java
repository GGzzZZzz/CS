import java.math.BigDecimal;

public class Computer extends ElectronicsProduct {

    public Computer(String name, BigDecimal price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
        this.guaranteePeriod = 24;
    }

    @Override
    public BigDecimal getPrice() {
        if(this.getQuantity() > 1000){
            return this.price.multiply(new BigDecimal(0.95));
        }

        return this.price;
    }
}