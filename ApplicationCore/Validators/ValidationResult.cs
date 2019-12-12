using System.Collections.Generic;
using System.Linq;

namespace FinanceApp.ApplicationCore.Validators
{
    public class ValidationResult
    {
        public List<KeyValuePair<string, string>> Errors { get; private set; } = new List<KeyValuePair<string, string>>();
        public bool IsValid { get => !Errors.Any(); }
        public void AddError(string modelKey, string errorMessage)
        {
            Errors.Add(new KeyValuePair<string, string>(modelKey, errorMessage));
        }
    }
}
