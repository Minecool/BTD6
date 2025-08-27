namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(MarkedToPop), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MarkedToPopModel : AbilityBehaviorModel
{
	public AttackModel markingAttackModel; //Field offset: 0x30
	public AttackModel executionAttackModel; //Field offset: 0x38
	public int markingTimeFrames; //Field offset: 0x40
	public int executionTimeMaxFrames; //Field offset: 0x44

	public MarkedToPopModel(string name, AttackModel markingAttackModel, AttackModel executionAttackModel, int markingTimeFrames, int executionTimeMaxFrames) { }

	public virtual Model Clone() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

