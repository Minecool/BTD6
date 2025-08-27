namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SoulbindManager), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SoulbindManagerModel : TowerBehaviorModel
{
	public EffectModel createEffectOnTowerSold; //Field offset: 0x30
	public PrefabReference assetId; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40

	public SoulbindManagerModel(string name, EffectModel createEffectOnTowerSold, PrefabReference assetId, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

