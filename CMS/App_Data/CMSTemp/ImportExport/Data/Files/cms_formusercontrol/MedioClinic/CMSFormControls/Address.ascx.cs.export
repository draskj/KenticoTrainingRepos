using CMS.FormEngine.Web.UI;
using CMS.Globalization;
using CMS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMSApp.MedioClinic.CMSFormControls
{
    public partial class Address : FormEngineUserControl
    {
        public override object Value
        {
            get
            {
                return $"{this.cityTextBoxID.Text}; {this.streetTextBoxID.Text}; {this.drpCountry.SelectedItem.Text}";
            }

            set
            {
               var results = value.ToString().Split(';');

                this.cityTextBoxID.Text = results[0];
                this.streetTextBoxID.Text = results[1];
                this.drpCountry.SelectedValue = results[2];
            }
        }

        //public override bool IsValid()
        //{
            
        //    //ValidationHelper.
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                drpCountry.DataSource = CountryInfoProvider.GetAllCountries();
                drpCountry.DataTextField = "CountryDisplayName";
                drpCountry.DataValueField = "CountryID";
                drpCountry.DataBind(); }
        }
    }
}