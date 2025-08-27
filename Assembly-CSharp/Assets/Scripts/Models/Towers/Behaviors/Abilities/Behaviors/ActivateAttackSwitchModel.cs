namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ActivateAttackSwitch), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateAttackSwitchModel : AbilityBehaviorModel
{
	public int lifespanFrames; //Field offset: 0x30
	public AttackModel firstAttack; //Field offset: 0x38
	public AttackModel secondAttack; //Field offset: 0x40
	public bool processOnActivate; //Field offset: 0x48

	public ActivateAttackSwitchModel(string name, int lifespanFrames, AttackModel firstAttack, AttackModel secondAttack, bool processOnActivate) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

