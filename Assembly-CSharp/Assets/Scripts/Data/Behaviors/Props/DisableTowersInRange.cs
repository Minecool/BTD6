namespace Assets.Scripts.Data.Behaviors.Props;

[CreateAssetMenu(fileName = "DisableTowersInRange", menuName = "BTD6/Behaviors/Props/DisableTowersInRange")]
public class DisableTowersInRange : PropBehavior
{
	public int range; //Field offset: 0x30
	public PrefabReference disabledTowerOverlayDisplay; //Field offset: 0x38

	public virtual PropBehaviorModel Def
	{
		 get { } //Length: 127
	}

	public DisableTowersInRange() { }

	public virtual PropBehaviorModel get_Def() { }

}

