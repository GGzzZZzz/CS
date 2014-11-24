import java.math.BigDecimal;

public class Customer {
    private String name;
    private int age;
    private BigDecimal balance;

    public Customer(String name, int age, BigDecimal balance) {
        this.setName(name);
        this.setAge(age);
        this.setBalance(balance);
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        if(name == null || name.isEmpty()){
            throw new IllegalArgumentException("Name can not be null or empty!");
        }

        this.name = name;
    }

    public int getAge() {
        return this.age;
    }

    public void setAge(int age) {
        if(age < 0){
            throw new IllegalArgumentException("Age can not be negative!");
        }

        this.age = age;
    }

    public BigDecimal getBalance() {
        return this.balance;
    }

    public void setBalance(BigDecimal balance) {
        this.balance = balance;
    }
}