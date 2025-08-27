namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AddSoundToShopMenu : TowerBehavior
{
	public AddSoundToShopMenu parent; //Field offset: 0x98
	public AudioClip openShopSound; //Field offset: 0xA0
	public AudioClip expOpenShopSound; //Field offset: 0xA8
	public AudioClip heroVoiceSound1; //Field offset: 0xB0
	public AudioClip expHeroVoiceSound1; //Field offset: 0xB8
	public AudioClip heroVoiceSound2; //Field offset: 0xC0
	public AudioClip expHeroVoiceSound2; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 633
	}

	public AddSoundToShopMenu() { }

	public virtual TowerBehaviorModel get_Def() { }

}

