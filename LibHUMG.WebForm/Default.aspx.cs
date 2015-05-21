using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibHUMG.BusinessLogic;
using LibHUMG.BusinessObjects;

namespace LibHUMG.WebForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadForm();
            }
        }
        public void LoadForm()
        {
            DocGiaBL objDocGiaBL = new DocGiaBL();
            gvDocGia.DataSource = objDocGiaBL.GetList();
            gvDocGia.DataBind();
        }
    }
}