namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PerRoundCashBonusTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PerRoundCashBonusTowerModel : TowerBehaviorModel
{
	public float cashPerRound; //Field offset: 0x30
	public float cashRoundBonusMultiplier; //Field offset: 0x34
	public float lifespan; //Field offset: 0x38
	public PrefabReference assetId; //Field offset: 0x40
	public bool distributeCash; //Field offset: 0x48

	public PerRoundCashBonusTowerModel(string name, float cashPerRound, float cashRoundBonusMultiplier, float lifespan, PrefabReference assetId, bool distributeCash) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

