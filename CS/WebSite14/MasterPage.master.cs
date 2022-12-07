using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void tcDemos_TabDataBound(object source, DevExpress.Web.TabControlEventArgs e) {
        Tab tab = e.Tab as Tab;
        if(tab == null) return;
        e.Tab.Name = ResolveClientUrl(tab.NavigateUrl);
    }
}
