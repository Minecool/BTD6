namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class RotateToTarget : AttackBehavior
{
	public RotateToTarget parent; //Field offset: 0x88
	public bool onlyRotateDuringThrow; //Field offset: 0x90
	public string expOnlyRotateDuringThrow; //Field offset: 0x98
	public bool useThrowMarkerHeight; //Field offset: 0xA0
	public string expUseThrowMarkerHeight; //Field offset: 0xA8
	public bool rotateOnlyOnThrow; //Field offset: 0xB0
	public string expRotateOnlyOnThrow; //Field offset: 0xB8
	public int additionalRotation; //Field offset: 0xC0
	public string expAdditionalRotation; //Field offset: 0xC8
	public bool dontRotateTower; //Field offset: 0xD0
	public string expDontRotateTower; //Field offset: 0xD8
	public bool useMainAttackRotation; //Field offset: 0xE0
	public string expUseMainAttackRotation; //Field offset: 0xE8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 205
	}

	public RotateToTarget() { }

	public virtual AttackBehaviorModel get_Def() { }

}

