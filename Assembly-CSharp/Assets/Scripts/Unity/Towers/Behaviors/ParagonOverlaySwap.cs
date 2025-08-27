namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ParagonOverlaySwap : TowerBehavior
{
	public string overlayType; //Field offset: 0x98
	public string expOverlayType; //Field offset: 0xA0
	public string mutatorId; //Field offset: 0xA8
	public int degree; //Field offset: 0xB0
	public string expDegree; //Field offset: 0xB8
	public bool applyToAllAbove; //Field offset: 0xC0
	public string expApplyToAllAbove; //Field offset: 0xC8
	private ParagonOverlaySwapModel def; //Field offset: 0xD0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 257
	}

	public ParagonOverlaySwap() { }

	public virtual TowerBehaviorModel get_Def() { }

}

