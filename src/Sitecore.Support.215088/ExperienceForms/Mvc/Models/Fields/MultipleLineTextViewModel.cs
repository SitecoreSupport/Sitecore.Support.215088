using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.ExperienceForms.Mvc.Models.Validation;

namespace Sitecore.Support.ExperienceForms.Mvc.Models.Fields
{
  public class MultipleLineTextViewModel : Sitecore.ExperienceForms.Mvc.Models.Fields.MultipleLineTextViewModel
  {
    [AllowHtml, DynamicRequired, DynamicValidation]
    public override string Value
    {
      get { return base.Value; }
      set { base.Value = value; }
    }
  }
}