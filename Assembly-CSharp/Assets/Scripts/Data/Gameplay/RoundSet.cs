namespace Assets.Scripts.Data.Gameplay;

[CreateAssetMenu(menuName = "BTD6/Round Set")]
public class RoundSet : ScriptableObject, IRoundSet
{
	[SerializeField]
	private List<RoundData> rounds; //Field offset: 0x18
	[SerializeField]
	private IncomeSet linkedIncomeSet; //Field offset: 0x20
	[SerializeField]
	private float scale; //Field offset: 0x28

	public RoundSetModel Def
	{
		 get { } //Length: 289
	}

	public override float Scale
	{
		 get { } //Length: 6
	}

	public RoundSet() { }

	[CompilerGenerated]
	private RoundModel <get_Def>b__7_0(RoundData data) { }

	public RoundSetModel get_Def() { }

	public override float get_Scale() { }

	public override RoundData GetRound(int idx) { }

	public void ImportJson(RoundSet data) { }

}

