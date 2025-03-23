using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Controllers.Base.Tests;

[Collection("Collection")]
public class BaseControllerTests : FixturedUnitTest
{
    public BaseControllerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
