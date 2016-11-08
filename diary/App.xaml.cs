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
        private TasksDataContext __tasksDataContext;
        public TasksDataContext tasksDataContext
        {
            get { return __tasksDataContext; }
        }
        private List<Tasks> __notFinished;
        public List<Tasks> notFinished
        {
            get{ return __notFinished; }
            set { __notFinished = value; }
        }
        private List<Tasks> __today;
        public List<Tasks> today
        {
            get { return __today; }
            set { __today = value; }
        }
        private List<Tasks> __finished;
        public List<Tasks> finished
        {
            get { return __finished; }
            set { __finished = value; }
        }
        private void InitTables()
        {
            var queryNotFinished = from c in tasksDataContext.tableTasks
                        where c.Status1.name != "finished"
                        select c;
            notFinished = queryNotFinished.ToList<Tasks>();
            var queryToday = from c in tasksDataContext.tableTasks
                             where c.Status1.name == "inTodayList"
                             select c;
            today = queryToday.ToList<Tasks>();
            var queryFinished = from c in tasksDataContext.tableTasks
                                where c.Status1.name == "finished"
                                select c;
            finished = queryFinished.ToList<Tasks>();
        }
    }
}
