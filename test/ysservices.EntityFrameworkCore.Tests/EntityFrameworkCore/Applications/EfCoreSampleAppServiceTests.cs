using ysservices.Samples;
using Xunit;

namespace ysservices.EntityFrameworkCore.Applications;

[Collection(ysservicesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ysservicesEntityFrameworkCoreTestModule>
{

}
