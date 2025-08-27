namespace Assets.Scripts.Unity.Map.Triggers;

public class CycleAreasAction : MapAction
{
	public Area[] areas; //Field offset: 0x20
	public bool invert; //Field offset: 0x28
	public bool fromStartingRound; //Field offset: 0x29
	private CycleAreasActionModel def; //Field offset: 0x30
	public int roundsPerRotate; //Field offset: 0x38

	public virtual MapActionModel Def
	{
		 get { } //Length: 571
	}

	public CycleAreasAction() { }

	public virtual MapActionModel get_Def() { }

}

