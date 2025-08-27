namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "Offset", menuName = "BTD6/Behaviors/Weapons/Offset")]
public class Offset : WeaponBehavior
{
	public float range; //Field offset: 0x30
	public float angleOffset; //Field offset: 0x34

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public Offset() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

