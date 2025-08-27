namespace Assets.Scripts.Unity.Powers;

public class CashDrop : PowerBehavior
{
	public Projectile projectile; //Field offset: 0x20

	public virtual PowerBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public CashDrop() { }

	public virtual PowerBehaviorModel get_Def() { }

}

