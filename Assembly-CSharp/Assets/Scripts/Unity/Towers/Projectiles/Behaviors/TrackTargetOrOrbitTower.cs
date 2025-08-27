namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TrackTargetOrOrbitTower : ProjectileBehavior
{
	public float maxTargetRange; //Field offset: 0x88
	public float rotation; //Field offset: 0x8C
	public float minimumSpeed; //Field offset: 0x90
	public float maximumSpeed; //Field offset: 0x94
	public float acceleration; //Field offset: 0x98
	public float accelerateInAngle; //Field offset: 0x9C
	public float startDeceleratingIfAngleGreaterThan; //Field offset: 0xA0
	public float orbitSpeed; //Field offset: 0xA4
	public float orbitDistance; //Field offset: 0xA8
	public float orbitTolerance; //Field offset: 0xAC
	public float searchDelay; //Field offset: 0xB0
	public string tagsToIgnore; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 446
	}

	public TrackTargetOrOrbitTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

