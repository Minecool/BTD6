namespace Assets.Scripts.Utils;

public class GarbageTrackerTest
{
	public class TestObject
	{
		public int numericID; //Field offset: 0x10
		public string id; //Field offset: 0x18

		public TestObject() { }

	}

	private List<TestObject> keep; //Field offset: 0x10

	public GarbageTrackerTest() { }

	public void Init() { }

	public void Test() { }

}

