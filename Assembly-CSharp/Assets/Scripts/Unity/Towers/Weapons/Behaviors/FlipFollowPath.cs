namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class FlipFollowPath : WeaponBehavior
{
	public FlipFollowPath parent; //Field offset: 0x90
	public bool flipTowerDisplayX; //Field offset: 0x98
	public string expFlipTowerDisplayX; //Field offset: 0xA0
	public bool flipTowerDisplayY; //Field offset: 0xA8
	public string expFlipTowerDisplayY; //Field offset: 0xB0
	public Effect effectOnFlip; //Field offset: 0xB8
	public Effect expEffectOnFlip; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 242
	}

	public FlipFollowPath() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

