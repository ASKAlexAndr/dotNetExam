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

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Exam.ExamDBDataSet examDBDataSet = ((Exam.ExamDBDataSet)(this.FindResource("examDBDataSet")));
            // Загрузить данные в таблицу Users. Можно изменить этот код как требуется.
            Exam.ExamDBDataSetTableAdapters.UsersTableAdapter examDBDataSetUsersTableAdapter = new Exam.ExamDBDataSetTableAdapters.UsersTableAdapter();
            examDBDataSetUsersTableAdapter.Fill(examDBDataSet.Users);
            System.Windows.Data.CollectionViewSource usersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("usersViewSource")));
            usersViewSource.View.MoveCurrentToFirst();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            Close();
            login.Show();
        }
    }
}
