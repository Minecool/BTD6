namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ChipMapBasedObject : ProjectileBehavior
{
	public ChipMapBasedObject parent; //Field offset: 0x88
	public string chipId; //Field offset: 0x90
	public string expChipId; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 138
	}

	public ChipMapBasedObject() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

