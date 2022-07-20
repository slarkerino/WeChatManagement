using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.WeChatManagement.Officials;

[DependsOn(
    typeof(WeChatManagementOfficialsApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class WeChatManagementOfficialsHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(WeChatManagementOfficialsApplicationContractsModule).Assembly,
            OfficialsRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<WeChatManagementOfficialsHttpApiClientModule>();
        });

    }
}
