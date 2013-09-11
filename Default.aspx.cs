using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblMessage.Text = DateTimePicker.DateTime;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        TextBox txtDateTime = (TextBox)DateTimePicker.FindControl("txtDateTime");
        txtDateTime.Text = string.Empty;
        lblMessage.Text = string.Empty;
    }
}
