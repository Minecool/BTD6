namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(Haunt), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HauntModel : BloonBehaviorModelWithTowerTracking
{
	public const string mutatorId = "Haunt"; //Field offset: 0x0
	public float bonusEnergyDamage; //Field offset: 0x38
	public int manaPerRbe; //Field offset: 0x3C
	public ProjectileModel projectileOnDestroyModel; //Field offset: 0x40
	public EffectModel effectModel; //Field offset: 0x48
	public SingleEmissionModel singleEmissionModel; //Field offset: 0x50

	public HauntModel(string name, ObjectId tower, float bonusEnergyDamage, int manaPerRbe, ProjectileModel projectileOnDestroyModel, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

