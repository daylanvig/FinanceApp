using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;

namespace FinanceApp.Web.HelperMethods
{
    public static class ModelStateExtensions
    {
        /// <summary>
        /// Adds a list of model errors to the ModelState
        /// </summary>
        /// <see cref="ModelStateDictionary.AddModelError(string, string)"/>
        /// <param name="errors">Collection of key value pairs where the key is the name of the attribute</param>
        public static void AddModelErrors(this ModelStateDictionary modelState, ICollection<KeyValuePair<string, string>> errors)
        {
            foreach(var error in errors)
            {
                modelState.AddModelError(error.Key, error.Value);
            }
        }
    }
}
