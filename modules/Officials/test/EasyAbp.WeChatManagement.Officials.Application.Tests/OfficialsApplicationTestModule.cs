using Volo.Abp.Modularity;

namespace EasyAbp.WeChatManagement.Officials;

[DependsOn(
    typeof(OfficialsApplicationModule),
    typeof(OfficialsDomainTestModule)
    )]
public class OfficialsApplicationTestModule : AbpModule
{

}
