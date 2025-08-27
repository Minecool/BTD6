namespace Assets.Scripts.Models.CorvusSpells.PassiveBonuses;

[Implementation(typeof(Attunement), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AttunementModel : TowerBehaviorModel
{
	public float maxSpeedMultiplier; //Field offset: 0x30
	public float maxDamageMultiplier; //Field offset: 0x34

	public AttunementModel(string name, float maxSpeedMultiplier, float maxDamageMultiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

