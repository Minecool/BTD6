namespace Assets.Scripts.Unity.Powers;

public class MoabMine : PowerBehavior
{
	public Projectile projectile; //Field offset: 0x20

	public virtual PowerBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public MoabMine() { }

	public virtual PowerBehaviorModel get_Def() { }

}

