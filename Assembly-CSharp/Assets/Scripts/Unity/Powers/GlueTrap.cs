namespace Assets.Scripts.Unity.Powers;

public class GlueTrap : PowerBehavior
{
	public Projectile projectile; //Field offset: 0x20

	public virtual PowerBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public GlueTrap() { }

	public virtual PowerBehaviorModel get_Def() { }

}

