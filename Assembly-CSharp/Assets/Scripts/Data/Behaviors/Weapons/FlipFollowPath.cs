namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "FlipFollowPath", menuName = "BTD6/Behaviors/Weapons/FlipFollowPath")]
public class FlipFollowPath : WeaponBehavior
{
	public bool flipTowerDisplayX; //Field offset: 0x30
	public bool flipTowerDisplayY; //Field offset: 0x31
	public Effect effectOnFlip; //Field offset: 0x38

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 242
	}

	public FlipFollowPath() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

