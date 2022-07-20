using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace EasyAbp.WeChatManagement.Officials;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(WeChatManagementOfficialsDomainSharedModule)
)]
public class WeChatManagementOfficialsDomainModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.PreConfigure<IIdentityServerBuilder>(builder =>
        {
            builder.AddExtensionGrantValidator<WeChatOfficialGrantValidator>();
        });
    }
}
