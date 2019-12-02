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

namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для StatisticPage.xaml
    /// </summary>
    public partial class StatisticPage : Page
    {
        public StatisticPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            Exam.ExamDBDataSet examDBDataSet = ((Exam.ExamDBDataSet)(this.FindResource("examDBDataSet")));
            // Загрузить данные в таблицу Users. Можно изменить этот код как требуется.
            Exam.ExamDBDataSetTableAdapters.ViewScoreTableAdapter examDBDataSetUsersTableAdapter = new Exam.ExamDBDataSetTableAdapters.ViewScoreTableAdapter();
            examDBDataSetUsersTableAdapter.Fill(examDBDataSet.ViewScore);
            System.Windows.Data.CollectionViewSource viewScoreViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("viewScoreViewSource")));
            viewScoreViewSource.View.MoveCurrentToFirst();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("HomePage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

    }
}
