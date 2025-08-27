namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ParagonOverlaySwap", menuName = "BTD6/Behaviors/Towers/ParagonOverlaySwap")]
public class ParagonOverlaySwap : TowerBehavior
{
	public string overlayType; //Field offset: 0x30
	public string mutatorId; //Field offset: 0x38
	public int degree; //Field offset: 0x40
	public bool applyToAllAbove; //Field offset: 0x44

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 151
	}

	public ParagonOverlaySwap() { }

	public virtual TowerBehaviorModel get_Def() { }

}

