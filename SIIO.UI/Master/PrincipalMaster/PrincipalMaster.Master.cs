using System;
using Atomo.Web;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace SIIO.UI.Master
{
    public partial class PrincipalMaster : MasterBase
    {
        public override List<string> GetCssCommon()
        {
            List<string> l = new List<string>();
            l.Add("site");
            l.Add("principalMaster");
            return l;
        }
    }
}