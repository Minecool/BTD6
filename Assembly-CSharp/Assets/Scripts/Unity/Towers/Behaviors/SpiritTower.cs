namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SpiritTower : TowerBehavior
{
	private SpiritTowerModel def; //Field offset: 0x98
	public bool playLevelUpEffect; //Field offset: 0xA0
	public string expPlayLevelUpEffect; //Field offset: 0xA8
	public Effect effectOnDroneUpgrade; //Field offset: 0xB0
	public Effect expEffectOnDroneUpgrade; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 262
	}

	public SpiritTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

