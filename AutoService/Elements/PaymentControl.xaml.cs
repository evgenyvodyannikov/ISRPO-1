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

namespace AutoService.Elements
{
    /// <summary>
    /// Логика взаимодействия для ClientControl.xaml
    /// </summary>
    public partial class ClientControl : UserControl
    {
        public ClientControl(Payment payment)
        {
            InitializeComponent();
            this.Name.Text = payment.Name;
            this.Type.Text = payment.Category;
            this.Date.Text = payment.Date;
        }
    }
}
