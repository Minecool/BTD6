namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(RotateToMiddleOfTargets), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RotateToMiddleOfTargetsModel : AttackBehaviorModel
{
	public bool onlyRotateDuringThrow; //Field offset: 0x30

	public RotateToMiddleOfTargetsModel(string name, bool onlyRotateDuringThrow) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

