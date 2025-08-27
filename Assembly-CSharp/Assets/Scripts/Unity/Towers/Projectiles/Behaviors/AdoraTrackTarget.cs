namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class AdoraTrackTarget : ProjectileBehavior
{
	public AdoraTrackTarget parent; //Field offset: 0x88
	public float rotation; //Field offset: 0x90
	public string expRotation; //Field offset: 0x98
	public float minimumSpeed; //Field offset: 0xA0
	public string expMinimumSpeed; //Field offset: 0xA8
	public float maximumSpeed; //Field offset: 0xB0
	public string expMaximumSpeed; //Field offset: 0xB8
	public float acceleration; //Field offset: 0xC0
	public string expAcceleration; //Field offset: 0xC8
	public float lifespan; //Field offset: 0xD0
	public string expLifespan; //Field offset: 0xD8
	public float accelerateInAngle; //Field offset: 0xE0
	public string expAccelerateInAngle; //Field offset: 0xE8
	public float startDeceleratingIfAngleGreaterThan; //Field offset: 0xF0
	public string expStartDeceleratingIfAngleGreaterThan; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 275
	}

	public AdoraTrackTarget() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

