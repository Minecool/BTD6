namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TrackManuallyGivenTarget : ProjectileBehavior
{
	public float turnRate; //Field offset: 0x88
	public string expTurnRate; //Field offset: 0x90
	public float minimumSpeed; //Field offset: 0x98
	public string expMinimumSpeed; //Field offset: 0xA0
	public float maximumSpeed; //Field offset: 0xA8
	public string expMaximumSpeed; //Field offset: 0xB0
	public float accelerationSpeed; //Field offset: 0xB8
	public string expAccelerationSpeed; //Field offset: 0xC0
	public float projectileLifeSpan; //Field offset: 0xC8
	public string expProjectileLifeSpan; //Field offset: 0xD0

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 223
	}

	public TrackManuallyGivenTarget() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

