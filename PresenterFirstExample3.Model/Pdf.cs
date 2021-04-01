using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterFirstExample3.Model
{
    public class Pdf
    {
        public Pdf(string pathToFile)
        {
            this.PathToFile = pathToFile;
        }

        public string PathToFile { get; }
    }
}
