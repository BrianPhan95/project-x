using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ProjectX;

[Dependency(ReplaceServices = true)]
public class ProjectXBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProjectX";
}
