namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(RotateToTargetAttackOffset), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RotateToTargetAttackOffsetModel : RotateToTargetModel
{
	[SerializeField]
	private float ignoreParentRotationTime; //Field offset: 0x40
	public int ignoreParentRotationFrames; //Field offset: 0x44
	public float startRotation; //Field offset: 0x48
	public bool alwaysIgnoreParentRotation; //Field offset: 0x4C

	public RotateToTargetAttackOffsetModel(string name, bool onlyRotateDuringThrow, bool useThrowMarkerHeight, bool rotateOnlyOnThrow, int additionalRotation, bool rotateTower, bool useMainAttackRotation, float ignoreParentRotationTime, float startRotation, bool alwaysIgnoreParentRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

