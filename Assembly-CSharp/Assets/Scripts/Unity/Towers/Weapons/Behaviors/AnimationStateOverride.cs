namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class AnimationStateOverride : WeaponBehavior
{
	public AnimationStateOverride parent; //Field offset: 0x90
	public int stateFrom; //Field offset: 0x98
	public string expStateFrom; //Field offset: 0xA0
	public int stateTo; //Field offset: 0xA8
	public string expStateTo; //Field offset: 0xB0
	public int overrideWith; //Field offset: 0xB8
	public string expOverrideWith; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 154
	}

	public AnimationStateOverride() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

