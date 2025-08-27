namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AdoraTrackTarget", menuName = "BTD6/Behaviors/Projectiles/AdoraTrackTarget")]
public class AdoraTrackTarget : ProjectileBehavior
{
	public float rotation; //Field offset: 0x30
	public float minimumSpeed; //Field offset: 0x34
	public float maximumSpeed; //Field offset: 0x38
	public float acceleration; //Field offset: 0x3C
	public float lifespan; //Field offset: 0x40
	public float accelerateInAngle; //Field offset: 0x44
	public float startDeceleratingIfAngleGreaterThan; //Field offset: 0x48

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 254
	}

	public AdoraTrackTarget() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

