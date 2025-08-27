namespace Assets.Scripts.Data.Accolades;

public class AllAccolades : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public AccoladeType accoladeType; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <GetAccoladeData>b__0(AccoladeData element) { }

	}

	[SerializeField]
	private List<AccoladeData> accoladesData; //Field offset: 0x18

	public IEnumerable<AccoladeData> AccoladesData
	{
		 get { } //Length: 5
	}

	public AllAccolades() { }

	public IEnumerable<AccoladeData> get_AccoladesData() { }

	public AccoladeData GetAccoladeData(AccoladeType accoladeType) { }

}

