namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateProjectilesOnTrackOnExpire : ProjectileBehavior
{
	public CreateProjectilesOnTrackOnExpire parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Emission emission; //Field offset: 0x98
	public bool useRotation; //Field offset: 0xA0
	public string expUseRotation; //Field offset: 0xA8
	public int count; //Field offset: 0xB0
	public string expCount; //Field offset: 0xB8
	public float range; //Field offset: 0xC0
	public string expRange; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 257
	}

	public CreateProjectilesOnTrackOnExpire() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

