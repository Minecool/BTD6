namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Cash), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CashModel : ProjectileBehaviorModel
{
	public float minimum; //Field offset: 0x38
	public float maximum; //Field offset: 0x3C
	public float bonusMultiplier; //Field offset: 0x40
	public float salvage; //Field offset: 0x44
	public bool noTransformCash; //Field offset: 0x48
	public bool distributeSalvage; //Field offset: 0x49
	public bool forceCreateProjectile; //Field offset: 0x4A
	public bool isDoubleable; //Field offset: 0x4B
	public bool distributeBonusIncome; //Field offset: 0x4C
	public float emittedByCashEarnedMultiplier; //Field offset: 0x50

	public CashModel(string name, float minimum, float maximum, float bonusMultiplier, float salvage, bool noTransformCash, bool distributeSalvage, bool forceCreateProjectile, bool isDoubleable, bool distributeBonusIncome, float emittedByCashEarnedMultiplier = 1) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

