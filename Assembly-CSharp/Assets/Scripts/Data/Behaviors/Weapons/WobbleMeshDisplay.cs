namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "WobbleMeshDisplay", menuName = "BTD6/Behaviors/Weapons/WobbleMeshDisplay")]
public class WobbleMeshDisplay : WeaponBehavior
{
	public float min; //Field offset: 0x30
	public float max; //Field offset: 0x34
	public float time; //Field offset: 0x38

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 155
	}

	public WobbleMeshDisplay() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

