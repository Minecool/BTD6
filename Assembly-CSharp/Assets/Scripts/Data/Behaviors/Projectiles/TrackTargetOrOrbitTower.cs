namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "TrackTargetOrOrbitTower", menuName = "BTD6/Behaviors/Projectiles/TrackTargetOrOrbitTower")]
public class TrackTargetOrOrbitTower : ProjectileBehavior
{
	public float maxTargetRange; //Field offset: 0x30
	public float rotation; //Field offset: 0x34
	public float minimumSpeed; //Field offset: 0x38
	public float maximumSpeed; //Field offset: 0x3C
	public float acceleration; //Field offset: 0x40
	public float accelerateInAngle; //Field offset: 0x44
	public float startDeceleratingIfAngleGreaterThan; //Field offset: 0x48
	public float orbitSpeed; //Field offset: 0x4C
	public float orbitDistance; //Field offset: 0x50
	public float orbitTolerance; //Field offset: 0x54
	public float searchDelay; //Field offset: 0x58
	public string tagsToIgnore; //Field offset: 0x60

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 408
	}

	public TrackTargetOrOrbitTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

