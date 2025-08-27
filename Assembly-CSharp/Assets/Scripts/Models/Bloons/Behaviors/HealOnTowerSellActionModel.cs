namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(HealOnTowerSellAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HealOnTowerSellActionModel : BloonBehaviorActionModel
{
	public int healAmount; //Field offset: 0x38
	public float healPercentForHighestTier; //Field offset: 0x3C
	public PrefabReference effectAtTower; //Field offset: 0x40

	public HealOnTowerSellActionModel() { }

	public HealOnTowerSellActionModel(string name, string actionId, int healAmount, float healPercentForHighestTier, PrefabReference effectAtTower) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

