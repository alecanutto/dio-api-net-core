using System.Collections.Generic;

namespace curso_api.Models
{
    public class CheckFieldsViewModelOutput
    {
        public IEnumerable<string> Errors { get; private set; }

        public CheckFieldsViewModelOutput(IEnumerable<string> errors)
        {
            Errors = errors;
        }

    }
}
