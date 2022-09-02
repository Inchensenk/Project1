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

namespace Project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                PhoneNumber primo = new PhoneNumber { Number = "899999" };
                PhoneNumber septimo = new PhoneNumber { Number = "875656" };
                PhoneNumber undo = new PhoneNumber { Number = "84325243" };
                db.PhoneNumbers.AddRange(primo, undo, septimo);

                User tom = new User { Name = "Tom", PhoneNumber = primo };
                User bill = new User { Name = "Bill", PhoneNumber = undo };
                User gevork = new User { Name = "Gevork", PhoneNumber = septimo };
                db.Users.AddRange(tom, bill, gevork);
                db.SaveChanges();
            }

            InitializeComponent();
        }
    }
}
