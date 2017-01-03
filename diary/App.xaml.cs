using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace diary
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            LoadTables();
        }
        private static TasksDataContext tasksDataContext = new TasksDataContext();
        public static List<Tasks> notFinished { get; set; }
        public static List<Tasks> today { get; set; }
        public static List<Tasks> finished { get; set; }
        public void LoadTables()
        {
            IEnumerable<Tasks> queryNotFinished = from tb in tasksDataContext.tableTasks
                        where tb.Status1.name.ToString() != "finished"
                        select tb;
            notFinished = queryNotFinished.ToList();
            IEnumerable<Tasks> queryToday = from tb in tasksDataContext.tableTasks
                             where tb.Status1.name.ToString() == "inTodayList"
                             select tb;
            today = queryToday.ToList();
            IEnumerable<Tasks> queryFinished = from tb in tasksDataContext.tableTasks
                                where tb.Status1.name.ToString() == "finished"
                                select tb;
            finished = queryFinished.ToList();

        }   
    }
}
