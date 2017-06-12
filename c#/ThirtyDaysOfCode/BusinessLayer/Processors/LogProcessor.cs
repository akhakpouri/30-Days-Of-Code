using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysOfCode.BusinessLayer.Processors
{
    public class LogProcessor
    {
        private static volatile LogProcessor instance;
        private static object syncRoot = new object();
        private static ILog logger;

        private LogProcessor()
        {
            if(logger == null)
            {

            }
        }

        public static LogProcessor Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new LogProcessor();
                    }
                }
                return instance;
            }
        }
    }
}
