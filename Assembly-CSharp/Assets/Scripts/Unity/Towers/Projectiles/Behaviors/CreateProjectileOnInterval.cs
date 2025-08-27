namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateProjectileOnInterval : ProjectileBehavior
{
	public CreateProjectileOnInterval parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Projectile expProjectile; //Field offset: 0x98
	public Emission emission; //Field offset: 0xA0
	public Emission expEmission; //Field offset: 0xA8
	public float interval; //Field offset: 0xB0
	public string expInterval; //Field offset: 0xB8
	public bool onlyIfHasTarget; //Field offset: 0xC0
	public string expOnlyIfHasTarget; //Field offset: 0xC8
	public float range; //Field offset: 0xD0
	public string expRange; //Field offset: 0xD8
	public string targetType; //Field offset: 0xE0
	public string expTargetType; //Field offset: 0xE8
	public bool isBuffedByRate; //Field offset: 0xF0
	public string expIsBuffedByRate; //Field offset: 0xF8
	public bool useRawWeaponRate; //Field offset: 0x100
	public string expUseRawWeaponRate; //Field offset: 0x108
	public bool onlyEmitOnce; //Field offset: 0x110
	public string expOnlyEmitOnce; //Field offset: 0x118

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 439
	}

	public CreateProjectileOnInterval() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

