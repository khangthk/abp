// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.PermissionManagement;

// ReSharper disable once CheckNamespace
namespace Volo.Abp.PermissionManagement.ClientProxies;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IPermissionAppService), typeof(PermissionsClientProxy))]
public partial class PermissionsClientProxy : ClientProxyBase<IPermissionAppService>, IPermissionAppService
{
    public virtual async Task<GetPermissionListResultDto> GetAsync(string providerName, string providerKey)
    {
        return await RequestAsync<GetPermissionListResultDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), providerName },
            { typeof(string), providerKey }
        });
    }

    public virtual async Task UpdateAsync(string providerName, string providerKey, UpdatePermissionsDto input)
    {
        await RequestAsync(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), providerName },
            { typeof(string), providerKey },
            { typeof(UpdatePermissionsDto), input }
        });
    }
}
