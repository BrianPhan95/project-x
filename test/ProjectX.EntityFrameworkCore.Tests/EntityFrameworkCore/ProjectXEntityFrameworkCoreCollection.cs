using Xunit;

namespace ProjectX.EntityFrameworkCore;

[CollectionDefinition(ProjectXTestConsts.CollectionDefinitionName)]
public class ProjectXEntityFrameworkCoreCollection : ICollectionFixture<ProjectXEntityFrameworkCoreFixture>
{

}
