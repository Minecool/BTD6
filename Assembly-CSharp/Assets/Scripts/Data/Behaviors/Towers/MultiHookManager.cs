namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "MultiHookManager", menuName = "BTD6/Behaviors/Towers/MultiHookManager")]
public class MultiHookManager : TowerBehavior
{
	public float minTimeBetweenHooks; //Field offset: 0x30
	public float reloadTime; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public MultiHookManager() { }

	public virtual TowerBehaviorModel get_Def() { }

}

