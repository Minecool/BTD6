namespace Assets.Scripts.Unity.Utils;

public class WeightedGroup
{
	private class WeightedItem
	{
		public U target; //Field offset: 0x0
		public float weight; //Field offset: 0x0
		public float normalisedWeight; //Field offset: 0x0
		public float rangeLow; //Field offset: 0x0
		public float rangeHigh; //Field offset: 0x0

		public WeightedItem`1(U target, float weight) { }

	}

	private List<WeightedItem`1<T, T>> items; //Field offset: 0x0

	public private int Count
	{
		 get { } //Length: 26
		private set { } //Length: 3
	}

	public WeightedGroup`1() { }

	public void Add(T target, float weight) { }

	public void Clear() { }

	public T Get(float randomSelector) { }

	public int get_Count() { }

	public T GetRandom() { }

	public T GetRandomItem(float min, float max) { }

	public List<T> GetRandomSet(int howMany) { }

	public List<T> GetRandomSet(int howMany, List<T> targetList) { }

	private void NormalizeWeights() { }

	private void set_Count(int value) { }

}

