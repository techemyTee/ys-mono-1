using Xunit;

namespace ysservices.EntityFrameworkCore;

[CollectionDefinition(ysservicesTestConsts.CollectionDefinitionName)]
public class ysservicesEntityFrameworkCoreCollection : ICollectionFixture<ysservicesEntityFrameworkCoreFixture>
{

}
