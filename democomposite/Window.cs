namespace democomposite
{
    public class Window
    {
        private Directory root;
        public Window()
        {
            root = new Directory();
            root.children.Add(new File());
            root.Show();
        }
        public void Show()
        {
            root.Show();
        }
    }
}