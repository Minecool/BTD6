namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class PierceFromLivesGained : WeaponBehavior
{
	public PierceFromLivesGained parent; //Field offset: 0x90
	public float piercePercentPerLife; //Field offset: 0x98
	public string expPiercePercentPerLife; //Field offset: 0xA0
	public int lifeCap; //Field offset: 0xA8
	public string expLifeCap; //Field offset: 0xB0
	public string saveId; //Field offset: 0xB8
	public string expSaveId; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 193
	}

	public PierceFromLivesGained() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

