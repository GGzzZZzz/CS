import java.math.BigDecimal;

public class Appliance extends ElectronicsProduct {
    public Appliance(String name, BigDecimal price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
        this.guaranteePeriod = 6;
    }

    @Override
    public BigDecimal getPrice() {
        if(this.getQuantity() < 50){
            return this.price.multiply(new BigDecimal(1.05));
        }

        return this.price;
    }
}
