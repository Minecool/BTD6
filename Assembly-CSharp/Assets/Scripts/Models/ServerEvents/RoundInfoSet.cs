namespace Assets.Scripts.Models.ServerEvents;

public class RoundInfoSet : ScriptableObject, IRoundSet
{
	[SerializeField]
	private List<RoundInfo> rounds; //Field offset: 0x18
	[SerializeField]
	private float scale; //Field offset: 0x20

	public override float Scale
	{
		 get { } //Length: 6
	}

	public RoundInfoSet() { }

	public override float get_Scale() { }

	public override RoundData GetRound(int idx) { }

}

