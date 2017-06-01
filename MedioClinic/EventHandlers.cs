using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.OnlineForms;
using MedioClinic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


[assembly: CMS.RegisterModule(typeof(EventHandlers))]

namespace MedioClinic
{
    
    public class EventHandlers : Module
    {
        public EventHandlers() : base("EventHandlers")
        {


        }

        protected override void OnInit()
        {
            DocumentEvents.Update.After += Update_After;
            BizFormItemEvents.Insert.After += Insert_After;
        }

        private void Insert_After(object sender, BizFormItemEventArgs e)
        {
          var doctorName = DocumentHelper.GetDocuments().Column("DocumentName")
                .WhereEquals("NodeID", e.Item.GetValue("Doctors")).TopN(1).FirstObject.DocumentName;

            using (WebClient client = new WebClient())
            {
                
            }
        }

        private void Update_After(object sender, DocumentEventArgs e)
        {
            //http://kenticoactum2.azurewebsites.net/Service.aspx
            HttpClient client = new HttpClient();
            client.GetAsync("http://kenticoactum2.azurewebsites.net/Service.aspx?name=Jyrka");

        }
    }
}
