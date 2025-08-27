namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(LifeRegen), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LifeRegenModel : TowerBehaviorModel
{
	public float regenAmount; //Field offset: 0x30
	public float overRegenAmount; //Field offset: 0x34
	public float lifespan; //Field offset: 0x38
	public PrefabReference assetId; //Field offset: 0x40

	public LifeRegenModel(string name, float regenAmount, float overRegenAmount, float lifespan, PrefabReference assetId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

