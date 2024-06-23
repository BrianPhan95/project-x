using ProjectX.Samples;
using Xunit;

namespace ProjectX.EntityFrameworkCore.Applications;

[Collection(ProjectXTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProjectXEntityFrameworkCoreTestModule>
{

}
