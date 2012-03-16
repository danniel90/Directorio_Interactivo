using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DirectorioInteractivo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DirectorioWebService.DirectorioService ws = new DirectorioWebService.DirectorioService();
            helloLbl.Text = ws.HelloWorld();
        }
    }
}