namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "BerserkerBrewCheck", menuName = "BTD6/Behaviors/Towers/BerserkerBrewCheck")]
public class BerserkerBrewCheck : TowerBehavior
{
	public int maxCount; //Field offset: 0x30
	public string mutationId; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 127
	}

	public BerserkerBrewCheck() { }

	public virtual TowerBehaviorModel get_Def() { }

}

