namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class RotateToPointer : AttackBehavior
{
	public RotateToPointer parent; //Field offset: 0x88
	public float rate; //Field offset: 0x90
	public string expRate; //Field offset: 0x98
	public bool rotateTower; //Field offset: 0xA0
	public string expRotateTower; //Field offset: 0xA8
	public bool rotateOnlyOnEmit; //Field offset: 0xB0
	public string expRotateOnlyOnEmit; //Field offset: 0xB8
	public bool alignToWeaponEject; //Field offset: 0xC0
	public string expAlignToWeaponEject; //Field offset: 0xC8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 374
	}

	public RotateToPointer() { }

	public virtual AttackBehaviorModel get_Def() { }

}

