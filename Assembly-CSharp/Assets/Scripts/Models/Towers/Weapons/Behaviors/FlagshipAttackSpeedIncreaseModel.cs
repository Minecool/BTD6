namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(FlagshipAttackSpeedIncrease), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FlagshipAttackSpeedIncreaseModel : TowerBehaviorBuffModel
{
	public float attackSpeedIncrease; //Field offset: 0x48
	public bool onlyAffectParagon; //Field offset: 0x4C
	public bool dontAffectSelf; //Field offset: 0x4D

	public FlagshipAttackSpeedIncreaseModel(string name, float attackSpeedIncrease, string buffLocsName, string buffIconName, bool isGlobalRange, bool onlyAffectParagon, bool dontAffectSelf) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

