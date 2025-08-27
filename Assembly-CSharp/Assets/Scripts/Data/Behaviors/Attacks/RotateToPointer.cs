namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "RotateToPointer", menuName = "BTD6/Behaviors/Attacks/RotateToPointer")]
public class RotateToPointer : AttackBehavior
{
	public float rate; //Field offset: 0x30
	public bool rotateTower; //Field offset: 0x34
	public bool rotateOnlyOnEmit; //Field offset: 0x35
	public bool alignToWeaponEject; //Field offset: 0x36
	public float weaponEjectZ; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 172
	}

	public RotateToPointer() { }

	public virtual AttackBehaviorModel get_Def() { }

}

