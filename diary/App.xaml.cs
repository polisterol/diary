using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;

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
        //public static List<Tasks> inList { get; set; }
        public static ObservableCollection<Tasks> inList { get; set; }
        //public static List<Tasks> today { get; set; }
        public static ObservableCollection<Tasks> today { get; set; }
        //public static List<Tasks> finished { get; set; }
        public static ObservableCollection<Tasks> finished { get; set; }
        public void LoadTables()
        {
            IEnumerable<Tasks> queryinList = from tb in tasksDataContext.Tasks
                        where tb.list.ToString() == "inList"
                        select tb;
            inList = new ObservableCollection<Tasks>(queryinList.ToList<Tasks>());
            //inList = queryinList.ToList<Tasks>();
            IEnumerable<Tasks> queryToday = from tb in tasksDataContext.Tasks
                        where tb.list.ToString() == "inTodayList"
                        select tb;
            today = new ObservableCollection<Tasks>(queryToday.ToList<Tasks>());
            //today = queryToday.ToList();
            IEnumerable<Tasks> queryFinished = from tb in tasksDataContext.Tasks
                        where tb.list.ToString() == "finished"
                        select tb;
            finished = new ObservableCollection<Tasks>(queryFinished.ToList<Tasks>());
            //finished = queryFinished.ToList();

        }   
    }
}
