using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportStudio.Designer.ViewModels
{
    internal class BandViewModel
    {
        public BandType BandType { get; }

        public BandViewModel(BandType bandType)
        {
            BandType = bandType;
        }
    }
}
