using System;
using System.Threading.Tasks;
using EasyAbp.Abp.WeChat.Official;
using EasyAbp.Abp.WeChat.Official.Infrastructure.OptionsResolve;
using EasyAbp.WeChatManagement.Common.WeChatApps;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Users;

namespace EasyAbp.Abp.WeChat
{
    public class ClaimsWeChatOfficialOptionsResolveContributor : IWeChatOfficialOptionsResolveContributor
    {
        public const string ContributorName = "WeChatManagementClaims";

        public string Name => ContributorName;

        public void Resolve(WeChatOfficialResolveContext context)
        {
            throw new NotImplementedException();
        }

        public async ValueTask ResolveAsync(WeChatOfficialResolveContext context)
        {
            var currentUser = context.ServiceProvider.GetRequiredService<ICurrentUser>();

            var appid = currentUser.FindClaim("appid");

            if (appid == null || appid.Value.IsNullOrEmpty())
            {
                return;
            }

            var weChatAppRepository = context.ServiceProvider.GetRequiredService<IWeChatAppRepository>();

            var official = await weChatAppRepository.GetOfficialAppByAppIdAsync(appid.Value);

            context.Options = new AbpWeChatOfficialOptions
            {
                OAuthRedirectUrl = null, // Todo
                AppId = official.AppId,
                AppSecret = official.AppSecret,
                EncodingAesKey = official.EncodingAesKey,
                Token = official.Token
            };
        }


    }
}