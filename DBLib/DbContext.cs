using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib
{
    public sealed class DbContext
    {
        private DbConnectDataContext db;
        private static volatile DbContext _instance;
        private static object syncRoot = new Object();
        private static string connectionString =
               @"Data Source=(localdb)\MSSQLLocalDB;" +
               @"Integrated Security=True;Connect Timeout=30;" +
               //@"AttachDbFilename=|DataDirectory|\ExamDB.mdf;";
               @"AttachDbFilename=D:\Dev\Exam\DBLib\ExamDB.mdf;";

        private DbContext() {
            db = new DbConnectDataContext(connectionString);
        }

        public static DbConnectDataContext Service
        {
            get { return Instance.db; }
        }

        private static DbContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new DbContext();
                    }
                }

                return _instance;
            }
        }
    }
}
