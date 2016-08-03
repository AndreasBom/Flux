using Abp.Web.Mvc.Views;

namespace Flux.Web.Views
{
    public abstract class FluxWebViewPageBase : FluxWebViewPageBase<dynamic>
    {

    }

    public abstract class FluxWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected FluxWebViewPageBase()
        {
            LocalizationSourceName = FluxConsts.LocalizationSourceName;
        }
    }
}