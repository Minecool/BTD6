namespace Assets.Scripts.Unity.Towers.Behaviors;

public class EziliSupport : TowerBehavior
{
	public EziliSupport parent; //Field offset: 0x98
	public float necroPierceMult; //Field offset: 0xA0
	public string expNecroPierceMult; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 127
	}

	public EziliSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

