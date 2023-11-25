using Demo_var_6.ApplicationData;
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

namespace Demo_var_6.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainSystemWindow.xaml
    /// </summary>
    public partial class MainSystemWindow : Page
    {
        public MainSystemWindow()
        {
            InitializeComponent();

            comboBoxDateFilter.Items.Add("Даты");
            foreach (var dateOfEvent in DbWorker.GetContext().Meropriyatiya.Select(x => x.date).Distinct())
            {
                comboBoxDateFilter.Items.Add(dateOfEvent);
            }
            comboBoxDateFilter.SelectedIndex = 0;

            comboBoxNapravleniyeFilter.Items.Add("Направления");
            //foreach (var napravleniye in DbWorker.GetContext().SelectSomeThing...)
            //{

            //}
            comboBoxNapravleniyeFilter.SelectedIndex = 0;
        }

        private void updateEventsList()
        {
            List<Meropriyatiya> events = DbWorker.GetContext().Meropriyatiya.ToList();

            if (comboBoxDateFilter.SelectedIndex > 0)
            {
                string selectedDate = comboBoxDateFilter.SelectedItem.ToString();
                events = events.Where(x => x.date.Equals(selectedDate)).ToList();
            }

            listBoxEvents.ItemsSource = events;
        }

        private void DateFilterChanged(object sender, SelectionChangedEventArgs e)
        {
            updateEventsList();
        }

        private void NapravleniyeFilterChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
