namespace APBD1S33219;

public class Camera : Device
{
    public int Resolution { get; }
    public bool LensExchangeable { get; }
    
    public Camera(string name, Manufacturer manufacturer, int price, int resolution, bool lensExchangeable) : base(name, manufacturer, price)
    {
        Resolution = resolution;
        LensExchangeable = lensExchangeable;
    }
}