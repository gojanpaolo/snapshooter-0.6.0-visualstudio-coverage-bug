using Snapshooter.Xunit;
using Xunit;

namespace snapshooter_0_5_8
{
    public class Tests
    {
        [Fact] public void Test() => new object().MatchSnapshot();
    }
}
