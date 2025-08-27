namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SpiritTower", menuName = "BTD6/Behaviors/Towers/SpiritTower")]
public class SpiritTower : TowerBehavior
{
	public bool playLevelUpEffect; //Field offset: 0x30
	public Effect effectOnDroneUpgrade; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 228
	}

	public SpiritTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

