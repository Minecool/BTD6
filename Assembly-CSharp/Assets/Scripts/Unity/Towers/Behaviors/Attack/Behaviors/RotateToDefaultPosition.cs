namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class RotateToDefaultPosition : AttackBehavior
{
	public RotateToTarget parent; //Field offset: 0x88
	public float rotation; //Field offset: 0x90
	public string expRotation; //Field offset: 0x98

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public RotateToDefaultPosition() { }

	public virtual AttackBehaviorModel get_Def() { }

}

