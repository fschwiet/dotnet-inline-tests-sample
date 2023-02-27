namespace Library;

public class SampleClassTests
{
	[Fact]
	public void CanCalculateSum()
	{
		Assert.Equal(2, new SampleClass().CalculateSum(1, 1));
	}
}
