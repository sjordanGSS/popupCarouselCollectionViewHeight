using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace popupCarouselCollectionViewHeight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPopup : Popup
    {
        public MyPopup()
        {
            InitializeComponent();
        }

        private void Button_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}