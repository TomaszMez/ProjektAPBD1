namespace APBD1S33219;

public class Rental
{
    public User RUser { get; }
    public Device RDevice { get; }
    public DateTime RentalDate { get; }
    public DateTime AgreedReturnDate { get; }
    public DateTime? ActualReturnDate { get; private set; }
    public bool? IsOnTime { get; private set; }

    public Rental(User user, Device device, DateTime rentalDate, DateTime agreedReturnDate)
    {
        RUser = user;
        RDevice = device;
        RentalDate = rentalDate;
        AgreedReturnDate = agreedReturnDate;
    }

    public void returnDevice()
    {
        ActualReturnDate = DateTime.Now;
        if (ActualReturnDate > AgreedReturnDate) IsOnTime = false;
        else IsOnTime = true;
    }
    
    
}