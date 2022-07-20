using Volo.Abp.Reflection;

namespace EasyAbp.WeChatManagement.Officials.Permissions;

public class OfficialsPermissions
{
    public const string GroupName = "Officials";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(OfficialsPermissions));
    }
}
