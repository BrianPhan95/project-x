using ProjectX.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProjectX.Permissions;

public class ProjectXPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProjectXPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProjectXPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProjectXResource>(name);
    }
}
