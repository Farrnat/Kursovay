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
using System.Windows.Shapes;

namespace AutoParts
{
    /// <summary>
    /// Логика взаимодействия для EngineWindow.xaml
    /// </summary>
    public partial class EngineWindow : Window
    {
        public EngineWindow()
        {
            InitializeComponent();

            AppContext db = new AppContext();
            List<Engine> engines = db.Engines.ToList();
            EnginesList.ItemsSource = engines;
        }
    }
}
