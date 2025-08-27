namespace Assets.Scripts.Unity.Powers;

public class DamageAll : PowerBehavior
{
	public float amount; //Field offset: 0x20

	public virtual PowerBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public DamageAll() { }

	public virtual PowerBehaviorModel get_Def() { }

}

