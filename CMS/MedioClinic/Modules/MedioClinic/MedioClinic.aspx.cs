using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MedioClinic;
using CMS.Membership;
using CMS.UIControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMSApp.MedioClinic.Modules.MedioClinic
{
    public partial class MedioClinic : CMSDeskPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonId_Click(object sender, EventArgs e)
        {

          
        }

        protected void idAddDoctor_Click(object sender, EventArgs e)
        {
            // Creates a new instance of the Tree provider
            TreeProvider tree = new TreeProvider(MembershipContext.AuthenticatedUser);

            // Gets the current site's root "/" page, which will serve as the parent page
            CMS.DocumentEngine.TreeNode parentPage = tree.SelectNodes()
                .Path("/Doctors")
                .OnCurrentSite()
                .Culture("en-us")
                .FirstObject;

            if (parentPage != null)
            {
                // Creates a new page of the "CMS.MenuItem" page type
                CMS.DocumentEngine.TreeNode newPage = Doctor.New(Doctor.CLASS_NAME, tree);

                // Sets the properties of the new page
                newPage.DocumentName = "SomeNewDoctor";

                newPage[nameof(Doctor.DoctorExpertise)] = "Expertise";
                newPage[nameof(Doctor.DoctorFullName)] = "Fullname";
                //newPage[nameof(Doctor.)] = "Expertise";

                newPage.DocumentCulture = "en-us";

                // Inserts the new page as a child of the parent page
                newPage.Insert(parentPage);
            }
        }
    }
}