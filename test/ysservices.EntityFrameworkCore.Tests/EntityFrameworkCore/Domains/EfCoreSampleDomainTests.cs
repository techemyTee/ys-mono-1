using ysservices.Samples;
using Xunit;

namespace ysservices.EntityFrameworkCore.Domains;

[Collection(ysservicesTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ysservicesEntityFrameworkCoreTestModule>
{

}
