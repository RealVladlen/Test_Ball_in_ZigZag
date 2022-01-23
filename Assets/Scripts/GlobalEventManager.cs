using System;

public class GlobalEventManager
{
    public static Action DiamondPickUp;
    public static Action GameOver;
    public static Action SpeedUp;

    public static void SendPickUpDiamond()
    {
        if(DiamondPickUp != null) DiamondPickUp.Invoke();
    }

    public static void SendGameOver()
    {
        if (GameOver != null) GameOver.Invoke();
    }

    public static void SendSpeedUp()
    {
        if (SpeedUp != null) SpeedUp.Invoke();
    }
}
