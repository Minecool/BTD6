namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "BananaBonusCashZone", menuName = "BTD6/Behaviors/Towers/BananaBonusCashZone")]
public class BananaBonusCashZone : TowerBehavior
{
	public float multiplier; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public BananaBonusCashZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

