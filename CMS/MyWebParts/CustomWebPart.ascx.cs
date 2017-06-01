using CMS.PortalEngine.Web.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMSApp.MyWebParts
{
    public partial class CustomWebPart : CMSAbstractWebPart
    {
        public string SomeMessage
        {
            get
            {
                return GetValue(nameof(SomeMessage)).ToString();
            }
            set
            {
                SetValue(nameof(SomeMessage), value);
            }
        }

        public string LowBMIMessage
        {

            get
            {
                return GetValue("LowBMIMessage").ToString();
            }
            set
            {
                SetValue("LowBMIMessage", value);
            }
        }


        public string HighBMIMessage
        {

            get
            {
                return GetValue("HighBMIMessage").ToString();
            }
            set
            {
                SetValue("HighBMIMessage", value);
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (this.GetBMI() > 25)
            {
                this.result.Text = this.HighBMIMessage + "BMI is: " + this.GetBMI().ToString();
            }

            else if (this.GetBMI() < 18.5)
            {
                this.result.Text = this.LowBMIMessage + "BMI is: " + this.GetBMI().ToString();
            }
            else
            {
                this.result.Text = this.GetBMI().ToString();
            }

        }

        private float GetBMI()
        {

            return float.Parse(this.weightTextBox.Text) / (float.Parse(this.heightIdTextBox.Text) * float.Parse(this.heightIdTextBox.Text));
        }
    }
}