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

namespace AutoService.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminUC.xaml
    /// </summary>
    public partial class AdminUC : UserControl
    {
        public Elements.ClientControl[] paymentsList;
        DataBase dataBase = new DataBase();
        public AdminUC()
        {
            InitializeComponent();
            paymentsList = new Elements.ClientControl[0];
            List<Payment> payments = dataBase.GetPayments();

            for (int i = 0; i < payments.Count; i++)
            {
                Array.Resize(ref paymentsList, paymentsList.Length + 1);
                paymentsList[i] = new Elements.ClientControl(payments[i]);
            }

            DoPaginate();
            GetPaginationPage(1);
        }

        public void DoPaginate()
        {
            int pageCount = (paymentsList.Length / 10) + 1;

            for (int i = 0; i < pageCount; i++)
            {
                var btn = new Button();
                btn.Content = i + 1;
                btn.Click += PageViewButton_Click;

                Buttons.Children.Add(btn);
            }
        }

        public void GetPaginationPage(int pageNum)
        {
            ItemList.Children.Clear();
            ItemsListScrollViewer.ScrollToVerticalOffset(0.0);
            for (int a = 0; a < 10; a++)
            {
                try
                {
                    if (pageNum != 1)
                    {
                        ItemList.Children.Add(paymentsList[pageNum * 10 + a]);
                    }
                    else ItemList.Children.Add(paymentsList[a]);
                }
                catch { }
            }
        }

        public void PageViewButton_Click(object sender, RoutedEventArgs e)
        {
            int pageNum = int.Parse(((Button)sender).Content.ToString());

            GetPaginationPage(pageNum);
        }
    }
}
