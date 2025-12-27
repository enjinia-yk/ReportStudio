using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportStudio.Domain.Bands;


namespace ReportStudio.Designer.ViewModels
{
    internal class DesignerViewModel
    {
        public ObservableCollection<BandViewModel> Bands { get; }

        public DesignerViewModel()
        {
            Bands = new ObservableCollection<BandViewModel>
            {
                new BandViewModel(BandType.ReportHeader),
                new BandViewModel(BandType.PageHeader),
                new BandViewModel(BandType.Detail),
                new BandViewModel(BandType.PageFooter),
                new BandViewModel(BandType.ReportFooter),
            };
        }
    }
}
