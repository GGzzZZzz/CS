import Interfaces.Buyable;

import java.math.BigDecimal;

public abstract class Product implements Buyable {
    protected String name;
    protected BigDecimal price;
    protected int quantity;
    protected AgeRestriction ageRestriction;

    protected Product(String name, BigDecimal price, int quantity, AgeRestriction ageRestriction) {
        this.setName(name);
        this.setPrice(price);
        this.setQuantity(quantity);
        this.setAgeRestriction(ageRestriction);
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        if (name == null || name.isEmpty()) {
            throw new IllegalArgumentException("Name can not be null or empty!");
        }

        this.name = name;
    }

    @Override
    public BigDecimal getPrice() {
        return this.price;
    }

    public void setPrice(BigDecimal price) {
        if (price.compareTo(new BigDecimal(0.0)) == -1) {
            throw new IllegalArgumentException("Price can not be negative!");
        }

        this.price = price;
    }

    public int getQuantity() {
        return this.quantity;
    }

    public void setQuantity(int quantity) {
        if (quantity < 0) {
            throw new IllegalArgumentException("Quantity can not be negative!");
        }

        this.quantity = quantity;
    }

    public AgeRestriction getAgeRestriction() {
        return this.ageRestriction;
    }

    public void setAgeRestriction(AgeRestriction ageRestriction) {
        this.ageRestriction = ageRestriction;
    }
}