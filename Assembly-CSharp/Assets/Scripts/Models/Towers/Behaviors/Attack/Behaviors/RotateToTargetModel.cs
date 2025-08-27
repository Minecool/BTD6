namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(RotateToTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RotateToTargetModel : AttackBehaviorModel
{
	public bool onlyRotateDuringThrow; //Field offset: 0x30
	public bool useThrowMarkerHeight; //Field offset: 0x31
	public bool rotateOnlyOnThrow; //Field offset: 0x32
	public int additionalRotation; //Field offset: 0x34
	public bool rotateTower; //Field offset: 0x38
	public bool useMainAttackRotation; //Field offset: 0x39

	public RotateToTargetModel(string name, bool onlyRotateDuringThrow, bool useThrowMarkerHeight, bool rotateOnlyOnThrow, int additionalRotation, bool rotateTower, bool useMainAttackRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

