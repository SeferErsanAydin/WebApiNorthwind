using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiNorthwind.Models;

namespace WebApiNorthwind.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        public DBTool() { }

        static NorthwindEntities _dbInstance;

        public static NorthwindEntities DBInstance
        {
            get
            {
                if (_dbInstance == null) _dbInstance = new NorthwindEntities();
                return _dbInstance;
            }
        }
    }
}