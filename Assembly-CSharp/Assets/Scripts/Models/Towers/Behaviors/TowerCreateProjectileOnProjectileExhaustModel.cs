namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerCreateProjectileOnProjectileExhaust), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerCreateProjectileOnProjectileExhaustModel : TowerBehaviorModel
{
	[ExtendedDrawer]
	[SerializeReference]
	public ProjectileModel projectileModel; //Field offset: 0x30
	[ExtendedDrawer]
	[SerializeReference]
	public EmissionModel emissionModel; //Field offset: 0x38
	public EffectModel effectModel; //Field offset: 0x40
	public String[] onlyCreateIfScriptsExists; //Field offset: 0x48
	public String[] dontCreateIfScriptsExist; //Field offset: 0x50
	public bool useChance; //Field offset: 0x58
	public float chance; //Field offset: 0x5C

	public TowerCreateProjectileOnProjectileExhaustModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, EffectModel effectModel, String[] onlyCreateIfScriptsExists, String[] dontCreateIfScriptsExist, bool useChance, float chance) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

