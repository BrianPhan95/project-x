using ProjectX.Samples;
using Xunit;

namespace ProjectX.EntityFrameworkCore.Domains;

[Collection(ProjectXTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProjectXEntityFrameworkCoreTestModule>
{

}
