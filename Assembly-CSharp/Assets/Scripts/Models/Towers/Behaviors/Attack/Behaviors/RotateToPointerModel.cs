namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(RotateToPointer), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RotateToPointerModel : AttackBehaviorModel
{
	public float rate; //Field offset: 0x30
	public float rateFrames; //Field offset: 0x34
	public bool rotateTower; //Field offset: 0x38
	public bool rotateOnlyOnEmit; //Field offset: 0x39
	public float weaponEjectZ; //Field offset: 0x3C

	public RotateToPointerModel(string name, float rate, bool rotateTower, bool rotateOnlyOnEmit, float weaponEjectZ) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

