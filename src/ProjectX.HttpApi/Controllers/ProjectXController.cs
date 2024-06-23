using ProjectX.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProjectX.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProjectXController : AbpControllerBase
{
    protected ProjectXController()
    {
        LocalizationResource = typeof(ProjectXResource);
    }
}
