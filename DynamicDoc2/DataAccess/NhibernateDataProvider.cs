using DynamicDoc2.Models;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DynamicDoc2.DataAccess
{
    public class NhibernateDataProvider
    {
        private static ISession Session = null;

        public ISession GetSession()
        {
            if (Session != null)
                return Session;

            var cfg = new Configuration();
            cfg.Properties.Add("use_proxy_validator", "false");
            cfg.Configure(HttpContext.Current.Server.MapPath("~/bin/Mapping/hibernate.cfg.xml"));

            var sessionFactory = cfg.BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            Session = session;


            return Session;
        }

        
    }
}