namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Pickup : ProjectileBehavior
{
	public Pickup parent; //Field offset: 0x88
	public float collectRadius; //Field offset: 0x90
	public string expCollectRadius; //Field offset: 0x98
	public float delay; //Field offset: 0xA0
	public string expDelay; //Field offset: 0xA8
	public bool isCamoPickup; //Field offset: 0xB0
	public string expIsCamoPickup; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 157
	}

	public Pickup() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

