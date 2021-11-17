using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Prism.Regions;
using MyModule.Views;

namespace MyModule.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        private readonly IRegionManager _regionManager;

        public MainView(IRegionManager regionManager)
        {
            InitializeComponent();

            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion<SubAView>("SecondaryRegion");


        }
    }
}
