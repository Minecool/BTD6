namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RoundBasedAttackSpeed), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RoundBasedAttackSpeedModel : TowerBehaviorModel
{
	public float maxWeaponAttackSpeed; //Field offset: 0x30
	public float bonusAttackSpeedPerRoundPercent; //Field offset: 0x34

	public RoundBasedAttackSpeedModel(string name, float maxWeaponAttackSpeed, float bonusAttackSpeedPerRoundPercent) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

