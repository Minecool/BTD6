namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class RotateToMiddleOfTargets : AttackBehavior
{
	public RotateToMiddleOfTargets parent; //Field offset: 0x88
	public bool onlyRotateDuringThrow; //Field offset: 0x90
	public string expOnlyRotateDuringThrow; //Field offset: 0x98

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public RotateToMiddleOfTargets() { }

	public virtual AttackBehaviorModel get_Def() { }

}

