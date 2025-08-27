namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class RotateToTargetAttackOffset : RotateToTarget
{
	public float ignoreParentRotationTime; //Field offset: 0xF0
	public string expIgnoreParentRotationTime; //Field offset: 0xF8
	public float startRotation; //Field offset: 0x100
	public string expStartRotation; //Field offset: 0x108
	public bool alwaysIgnoreParentRotation; //Field offset: 0x110
	public string expAlwaysIgnoreParentRotation; //Field offset: 0x118

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 287
	}

	public RotateToTargetAttackOffset() { }

	public virtual AttackBehaviorModel get_Def() { }

}

