using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Sitecore.ExperienceForms.Mvc.Models.Validation;

namespace Sitecore.Support.ExperienceForms.Mvc.Models.Fields
{
  public class StringInputViewModel: Sitecore.ExperienceForms.Mvc.Models.Fields.StringInputViewModel
  {
    [AllowHtml, DynamicRequired, DynamicValidation]
    public override string Value
    {
      get { return base.Value; }
      set { base.Value = value; }
    }
  }
}
