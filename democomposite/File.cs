using System;
using System.Collections.Generic;
using System.Linq;
using  System.Threading.Tasks;
namespace democomposite
{
    public class File:GeneralFile
    {
        public File() { }

        public File(string name, int size) : base(name) {
            this.size = size;
        }
        public override List<GeneralFile> GetChildren()
        {
            return new List<GeneralFile>();
        }

        public override void Show()
        {
            System.Console.WriteLine(String.Format("{0,25} -{1,9}bytes",name, size));
        }

        public override int GetSize()
        {
            return size;
        }
    }
}