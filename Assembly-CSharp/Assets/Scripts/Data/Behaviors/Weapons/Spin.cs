namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "Spin", menuName = "BTD6/Behaviors/Weapons/Spin")]
public class Spin : WeaponBehavior
{
	public float rotationPerSecond; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public Spin() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

