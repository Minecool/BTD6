namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "VisibilitySupport", menuName = "BTD6/Behaviors/Towers/VisibilitySupport")]
public class VisibilitySupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public string mutatorId; //Field offset: 0x50
	public bool isGlobal; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 275
	}

	public VisibilitySupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

