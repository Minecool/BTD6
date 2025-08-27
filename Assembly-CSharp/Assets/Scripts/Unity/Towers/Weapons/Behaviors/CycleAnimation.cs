namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CycleAnimation : WeaponBehavior
{
	public CycleAnimation parent; //Field offset: 0x90
	public int minAnimationState; //Field offset: 0x98
	public string expMinAnimationState; //Field offset: 0xA0
	public int maxAnimationState; //Field offset: 0xA8
	public string expMaxAnimationState; //Field offset: 0xB0
	public string loopMode; //Field offset: 0xB8
	public string expLoopMode; //Field offset: 0xC0
	public bool randomize; //Field offset: 0xC8
	public string expRandomize; //Field offset: 0xD0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 164
	}

	public CycleAnimation() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

