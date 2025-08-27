namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DruidVengeanceEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DruidVengeanceEffectModel : TowerBehaviorModel
{
	public DamageModifierWrathModel damageModifierWrathModel; //Field offset: 0x30
	public EffectModel smallGlowEffectModel; //Field offset: 0x38
	public EffectModel mediumGlowEffectModel; //Field offset: 0x40
	public EffectModel epicGlowEffectModel; //Field offset: 0x48
	public PrefabReference defaultProjectilePath; //Field offset: 0x50
	public PrefabReference weakProjectilePath; //Field offset: 0x58
	public PrefabReference mediumProjectilePath; //Field offset: 0x60
	public PrefabReference epicProjectilePath; //Field offset: 0x68
	public int smallGlowEffectStacks; //Field offset: 0x70
	public int mediumGlowEffectStacks; //Field offset: 0x74
	public int epicGlowEffectStacks; //Field offset: 0x78

	public DruidVengeanceEffectModel(string name, DamageModifierWrathModel damageModifierWrathModel, EffectModel smallEffectModel, EffectModel mediumGlowEffectModel, EffectModel epicGlowEffectModel, PrefabReference defaultProjectilePath, PrefabReference weakProjectilePath, PrefabReference mediumProjectilePath, PrefabReference epicProjectilePath, int smallGlowEffectStacks, int mediumGlowEffectStacks, int epicGlowEffectStacks) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

