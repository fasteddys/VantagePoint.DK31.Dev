//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Serenity;
//using Serenity.Data;
//using Serenity.Services;
//using Serenity.Common.Services;
//using static MVC.Views.Vantage;
//using PrototypeB.Vantage.Entities;
//using PrototypeB.Vantage.Repositories;

//namespace PrototypeB.Web.Backend.Jobs
//{
//    public class ScheduledConf : PeriodicBackgroundTask, IBackgroundTask
//    {
//        private IKeyholderRepository keyholderRep = new KeyholderRepository();


//        protected override TimeSpan GetInterval()
//        {
//            //var config = Config.Get<MailingServiceSettings>();
//            return TimeSpan.FromSeconds(45);
//        }

//        protected override void InternalRun()
//        {
//            //var env = Config.Get<EnvironmentSettings>();
//            //var config = Config.Get<MailingServiceSettings>();

//            //if (!config.Enabled)
//            //    return;

//            var timeStamp = DateTime.Now;
//            string stimeStamp = timeStamp.ToString();

//            keyholderRep.UpdateKeyValue("JobConfirmation", stimeStamp);

//        }


//    }
//}
