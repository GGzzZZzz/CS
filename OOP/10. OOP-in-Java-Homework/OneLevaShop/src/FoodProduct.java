import Interfaces.Expirable;

import java.math.BigDecimal;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;

public class FoodProduct extends Product implements Expirable {
    private boolean hasExpired;
    private Date expirationDate;

    public FoodProduct(
            String name,
            BigDecimal price,
            int quantity,
            AgeRestriction ageRestriction,
            String expirationDate) {
        super(name, price, quantity, ageRestriction);
        this.setExpirationDate(expirationDate);
        this.hasExpired = HasExpired();

    }

    public boolean getHasExpired() {
        return this.hasExpired;
    }

    private boolean HasExpired(){
        Date today = new Date();
        boolean hasExpired = false;
        if(this.expirationDate.before(today)){
            hasExpired = true;
        }

        return hasExpired;
    }

    @Override
    public BigDecimal getPrice() {
        if(IsExpiring()){
            return this.price.multiply(new BigDecimal(0.70));
        }

        return this.price;
    }

    @Override
    public Date getExpirationDate() {
        return this.expirationDate;
    }

    public void setExpirationDate(String expirationDate) {

        String dateFormat = "dd/MM/yyyy";
        try {
            this.expirationDate = parseDate(expirationDate, dateFormat);

        } catch (ParseException pe) {
            throw new IllegalArgumentException("Incorrect date format!");
        }
    }

    private static Date parseDate(String date, String format) throws ParseException {
        SimpleDateFormat formatter = new SimpleDateFormat(format);
        return formatter.parse(date);
    }

    private boolean IsExpiring() {
        Calendar cal1 = new GregorianCalendar();
        Calendar cal2 = new GregorianCalendar();

        Date currentDate = new Date();
        cal1.setTime(currentDate);
        cal2.setTime(this.getExpirationDate());

        int days = daysBetween(cal1.getTime(), cal2.getTime());

        boolean isExpiring = false;
        if (days <= 15) {
            isExpiring = true;
        }

        return isExpiring;

    }

    private static int daysBetween(Date d1, Date d2) {
        return (int) ((d2.getTime() - d1.getTime()) / (1000 * 60 * 60 * 24));
    }
}