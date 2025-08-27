namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(WallOfTrees), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WallOfTreesModel : ProjectileBehaviorModel
{
	public float rbeCapacity; //Field offset: 0x38
	public float rbeCashMultiplier; //Field offset: 0x3C
	public ProjectileModel projectile; //Field offset: 0x40
	public EmissionModel emission; //Field offset: 0x48
	public int animationStateSpawnIn; //Field offset: 0x50
	public bool onlyDamageLastBloon; //Field offset: 0x54

	public WallOfTreesModel(string name, float rbeCapacity, float rbeCashMultiplier, ProjectileModel projectile, EmissionModel emission, int animationStateSpawnIn, bool onlyDamageLastBloon) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

