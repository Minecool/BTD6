namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(SellTowersInRadiusAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SellTowersInRadiusActionModel : BloonBehaviorActionModel
{
	public float radius; //Field offset: 0x38
	public PrefabReference towerSellEffect; //Field offset: 0x40
	public float towerSellEffectTime; //Field offset: 0x48

	public SellTowersInRadiusActionModel() { }

	public SellTowersInRadiusActionModel(string name, string actionId, float radius, PrefabReference towerSellEffect, float towerSellEffectTime) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

