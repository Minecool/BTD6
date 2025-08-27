namespace Assets.Scripts.Unity.MapProps.Behaviors;

public class DisableTowersInRange : PropBehavior
{
	public int range; //Field offset: 0x90
	public string expRange; //Field offset: 0x98
	public PrefabReference disabledTowerOverlayDisplay; //Field offset: 0xA0
	public PrefabReference expDisabledTowerOverlayDisplay; //Field offset: 0xA8

	public virtual PropBehaviorModel Def
	{
		 get { } //Length: 133
	}

	public DisableTowersInRange() { }

	public virtual PropBehaviorModel get_Def() { }

}

