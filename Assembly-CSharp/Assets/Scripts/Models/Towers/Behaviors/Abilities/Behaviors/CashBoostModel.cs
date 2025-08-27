namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(CashBoost), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CashBoostModel : AbilityBehaviorModel
{
	public int lifespanFrames; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34
	public float range; //Field offset: 0x38
	public string filterTower; //Field offset: 0x40

	public CashBoostModel(string name, int lifespanFrames, float multiplier, float range, string filterTower) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

