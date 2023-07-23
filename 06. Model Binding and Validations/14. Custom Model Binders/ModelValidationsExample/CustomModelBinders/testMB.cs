using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ModelValidationsExample.CustomModelBinders
{
    public class testMB : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            throw new NotImplementedException();
        }
    }
}
