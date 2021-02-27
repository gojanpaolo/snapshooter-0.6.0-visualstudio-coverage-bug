using Snapshooter.Xunit;
using Xunit;

namespace snapshooter_0_6_0
{
    public class Tests
    {
        [Fact] public void Test() => new object().MatchSnapshot();
    }
}
