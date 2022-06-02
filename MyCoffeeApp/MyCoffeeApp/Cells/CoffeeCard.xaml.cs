using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Cells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeCard : Grid
    {
        public CoffeeCard()
        {
            InitializeComponent();
        }
    }
}