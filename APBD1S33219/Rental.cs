namespace APBD1S33219;

public class Rental
{
    public User RUser { get; }
    public Device RDevice { get; }
    public DateTime RentalDate { get; }
    public TimeSpan RentalDuration { get; }
    public DateTime? ReturnDate { get; private set; }
    public bool? IsOnTime { get; private set; }

    public Rental(User user, Device device, DateTime rentalDate, TimeSpan rentalDuration)
    {
        RUser = user;
        RDevice = device;
        RentalDate = rentalDate;
        RentalDuration = rentalDuration;
    }

    public void returnDevice()
    {
        ReturnDate = DateTime.Now;
        if (ReturnDate > RentalDate + RentalDuration) IsOnTime = false;
        else IsOnTime = true;
    }
    
    
}