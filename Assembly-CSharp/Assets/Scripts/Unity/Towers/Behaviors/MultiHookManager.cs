namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MultiHookManager : TowerBehavior
{
	public MultiHookManager parent; //Field offset: 0x98
	public float minTimeBetweenHooks; //Field offset: 0xA0
	public string expMinTimeBetweenHooks; //Field offset: 0xA8
	public float reloadTime; //Field offset: 0xB0
	public string expReloadTime; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public MultiHookManager() { }

	public virtual TowerBehaviorModel get_Def() { }

}

