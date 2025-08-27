namespace Assets.Scripts.Unity.Powers;

public class CamoTrap : PowerBehavior
{
	public Projectile projectile; //Field offset: 0x20

	public virtual PowerBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public CamoTrap() { }

	public virtual PowerBehaviorModel get_Def() { }

}

