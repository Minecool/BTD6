namespace Assets.Scripts.Unity.Towers.Behaviors;

public class FreeUpgradeSupport : SupportBehavior
{
	public FreeUpgradeSupport parent; //Field offset: 0xC8
	public string mutatorId; //Field offset: 0xD0
	public string expMutatorId; //Field offset: 0xD8
	public int upgrade; //Field offset: 0xE0
	public string expUpgrade; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 163
	}

	public FreeUpgradeSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

