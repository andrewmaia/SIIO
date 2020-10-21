using System;
using SIIO.BO;
using SIIO.Model;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Erro
{
    public partial class BadRequest : Atomo.Web.Page
    {
        public override List<string> GetCssLinked()
        {
            List<string> l = new List<string>();
            l.Add("badRequest");
            return l;
        }
    }
}