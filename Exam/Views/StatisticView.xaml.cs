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

namespace Exam.Views
{
    /// <summary>
    /// Логика взаимодействия для StatisticView.xaml
    /// </summary>
    public partial class StatisticView : UserControl
    {
        public StatisticView()
        {
            InitializeComponent();
        }
        public ICommand ToHomeCommand { get; set; }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Exam.ExamDBDataSet examDBDataSet = ((Exam.ExamDBDataSet)(this.FindResource("examDBDataSet")));
                // Загрузить данные в таблицу Users. Можно изменить этот код как требуется.
                Exam.ExamDBDataSetTableAdapters.ViewScoreTableAdapter examDBDataSetUsersTableAdapter = new Exam.ExamDBDataSetTableAdapters.ViewScoreTableAdapter();
                examDBDataSetUsersTableAdapter.Fill(examDBDataSet.ViewScore);
                System.Windows.Data.CollectionViewSource viewScoreViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("viewScoreViewSource")));
                viewScoreViewSource.View.MoveCurrentToFirst();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
