namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ParagonSacrificeBonus", menuName = "BTD6/Behaviors/Towers/ParagonSacrificeBonus")]
public class ParagonSacrificeBonus : TowerBehavior
{
	public float bonus; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public ParagonSacrificeBonus() { }

	public virtual TowerBehaviorModel get_Def() { }

}

