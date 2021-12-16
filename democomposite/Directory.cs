using System;
using System.Collections.Generic;
using System.Linq;
using  System.Threading.Tasks;
namespace democomposite
{
    public class Directory:GeneralFile
    {
        public List<GeneralFile> children;
        private const int DIR_SIZE=4;
        public Directory()
        {
            children = new List<GeneralFile>();
            name="new Directory";
            size = DIR_SIZE;
        }
        public Directory(string name)
        {
            children = new List<GeneralFile>();
            Name = name;
            size = DIR_SIZE;
        }

        public override List<GeneralFile> GetChildren()
        {
            return children;
        }


        public override void Show()
        {
            System.Console.WriteLine(String.Format("{0,25} -{1,9}bytes",name, GetSize()));
            foreach (GeneralFile g in children)
            {
                g.Show();
            }
        }

        public override int GetSize()
        {
            int totalSize=size;
            foreach(GeneralFile g in children)
            {
                totalSize += g.GetSize();

            }
            return totalSize;
        }

        public void AddChild(GeneralFile file){
            children.Add(file);
        }

    }
}