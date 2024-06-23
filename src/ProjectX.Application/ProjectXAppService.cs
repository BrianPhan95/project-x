using System;
using System.Collections.Generic;
using System.Text;
using ProjectX.Localization;
using Volo.Abp.Application.Services;

namespace ProjectX;

/* Inherit your application services from this class.
 */
public abstract class ProjectXAppService : ApplicationService
{
    protected ProjectXAppService()
    {
        LocalizationResource = typeof(ProjectXResource);
    }
}
