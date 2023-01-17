namespace WinFormsLibrary1;

public abstract class Frame : MenuContainer
{
    public MenuBar? menuBar;
    public String? setTitle;
    public void remove(MenuBar menu)
    {
    }
    public abstract void paramString();
}