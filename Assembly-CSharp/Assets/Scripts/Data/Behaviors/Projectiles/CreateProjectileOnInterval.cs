namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateProjectileOnInterval", menuName = "BTD6/Behaviors/Projectiles/CreateProjectileOnInterval")]
public class CreateProjectileOnInterval : ProjectileBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public float interval; //Field offset: 0x40
	public bool onlyIfHasTarget; //Field offset: 0x44
	public float range; //Field offset: 0x48
	public string targetType; //Field offset: 0x50
	public bool isBuffedByRate; //Field offset: 0x58
	public bool useRawWeaponRate; //Field offset: 0x59
	public bool onlyEmitOnce; //Field offset: 0x5A

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 424
	}

	public CreateProjectileOnInterval() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

