namespace WinFormsLibrary1
{
    public class MenuBar
    {
        List<Menultem> menultem;
        public MenuBar(List<Menultem> men) {
            menultem = men;
        }

        public Frame? Frame { get; set; }
    }
    
}
