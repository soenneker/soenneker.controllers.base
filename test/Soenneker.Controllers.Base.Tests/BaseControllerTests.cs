using Soenneker.Tests.HostedUnit;

namespace Soenneker.Controllers.Base.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class BaseControllerTests : HostedUnitTest
{
    public BaseControllerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
