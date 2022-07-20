using Volo.Abp;
using Volo.Abp.MongoDB;

namespace EasyAbp.WeChatManagement.Officials.MongoDB;

public static class OfficialsMongoDbContextExtensions
{
    public static void ConfigureOfficials(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
