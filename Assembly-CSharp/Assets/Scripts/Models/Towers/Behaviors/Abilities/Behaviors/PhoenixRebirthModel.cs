namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(PhoenixRebirth), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PhoenixRebirthModel : AbilityBehaviorModel
{
	public float duration; //Field offset: 0x30
	public EffectModel effectTowerModel; //Field offset: 0x38
	public EffectModel effectSubtowerModel; //Field offset: 0x40
	public EffectModel effectEndSubtowerModel; //Field offset: 0x48
	public TowerModel[] disabledSubTowers; //Field offset: 0x50
	public ProjectileModel projectileExplosionModel; //Field offset: 0x58
	public int manaPerZombieZOMG; //Field offset: 0x60
	public int maxZombieZOMGs; //Field offset: 0x64
	public int zombieBFBsPerZOMG; //Field offset: 0x68
	public ProjectileModel projectileZOMG; //Field offset: 0x70
	public ProjectileModel projectileBFB; //Field offset: 0x78

	public PhoenixRebirthModel(string name, float duration, EffectModel effectTowerModel, EffectModel effectSubtowerModel, EffectModel effectEndSubtowerModel, TowerModel[] disabledSubTowers, ProjectileModel projectileExplosionModel, int manaPerZombieZOMG, int maxZombieZOMGs, int zombieBFBsPerZOMG, ProjectileModel projectileZOMG, ProjectileModel projectileBFB) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

