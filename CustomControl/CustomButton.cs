namespace LTUD1_MF_BHX;

public class CustomButton : Button
{
    public CustomButton(string text, EventHandler eventHandler)
    {
        Text = text;
        Click += eventHandler;
    }
}
