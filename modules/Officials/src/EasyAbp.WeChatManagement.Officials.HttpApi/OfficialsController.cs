using EasyAbp.WeChatManagement.Officials.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.WeChatManagement.Officials;

public abstract class OfficialsController : AbpControllerBase
{
    protected OfficialsController()
    {
        LocalizationResource = typeof(OfficialsResource);
    }
}
