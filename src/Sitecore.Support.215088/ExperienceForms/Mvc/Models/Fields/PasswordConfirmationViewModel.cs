using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.ExperienceForms.Mvc.Constants;
using Sitecore.ExperienceForms.Mvc.Models.Fields;
using Sitecore.ExperienceForms.Mvc.Models.Validation;

namespace Sitecore.Support.ExperienceForms.Mvc.Models.Fields
{
  [Serializable]
  public class PasswordConfirmationViewModel : Sitecore.Support.ExperienceForms.Mvc.Models.Fields.StringInputViewModel
  {
    /// <summary>
    /// Gets or sets the password confirmation label.
    /// </summary>
    public string ConfirmPasswordLabel { get; set; }

    /// <summary>
    /// Gets or sets the password confirmation placeholder.
    /// </summary>
    public string ConfirmPasswordPlaceholder { get; set; }

    /// <summary>
    /// Gets or sets the password confirmation.
    /// </summary>
    [LocalizedCompare("Value", TitleProperty = "ConfirmPasswordLabel", OtherTitleProperty = "Title", ErrorMessage = Texts.PasswordsNotMatching)]
    public string ConfirmPassword { get; set; }

    /// <summary>
    /// Initializes the model properties from the <paramref name="item" />.
    /// </summary>
    /// <param name="item">The item.</param>
    protected override void InitItemProperties(Item item)
    {
      Assert.ArgumentNotNull(item, nameof(item));
      base.InitItemProperties(item);

      ConfirmPasswordLabel = StringUtil.GetString(item.Fields[FieldNames.ConfirmPasswordLabel]);
      ConfirmPasswordPlaceholder = StringUtil.GetString(item.Fields[FieldNames.ConfirmPasswordPlaceholder]);
    }

    /// <summary>
    /// Updates the <paramref name="item" /> fields using the model properties.
    /// </summary>
    /// <param name="item">The item.</param>
    protected override void UpdateItemFields(Item item)
    {
      Assert.ArgumentNotNull(item, nameof(item));
      base.UpdateItemFields(item);

      item.Fields[FieldNames.ConfirmPasswordLabel]?.SetValue(ConfirmPasswordLabel, true);
      item.Fields[FieldNames.ConfirmPasswordPlaceholder]?.SetValue(ConfirmPasswordPlaceholder, true);
    }
  }
}