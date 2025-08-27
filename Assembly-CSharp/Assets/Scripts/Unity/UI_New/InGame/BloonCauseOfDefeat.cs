namespace Assets.Scripts.Unity.UI_New.InGame;

public class BloonCauseOfDefeat
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<BloonCoDData> <>9__8_0; //Field offset: 0x8
		public static Comparison<BloonCoDData> <>9__10_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <FinalizeDeath>b__10_0(BloonCoDData x, BloonCoDData y) { }

		internal int <UpdateBloonLeaks>b__8_0(BloonCoDData x, BloonCoDData y) { }

	}

	private static int totalBloons; //Field offset: 0x0
	private static int finalBloonCount; //Field offset: 0x4
	private static int cullTime; //Field offset: 0x8
	private List<BloonCoDData> bloonCoDDataList; //Field offset: 0x10
	private Dictionary<String, Single> finalDataList; //Field offset: 0x18

	public List<BloonCoDData> BloonCoDDataList
	{
		 get { } //Length: 5
	}

	private static BloonCauseOfDefeat() { }

	public BloonCauseOfDefeat() { }

	private void ClearLeakList() { }

	public void FinalizeDeath(int timeOfDeath) { }

	public List<BloonCoDData> get_BloonCoDDataList() { }

	public void Init() { }

	public void UpdateBloonLeaks(string id, float damage, int time) { }

}

