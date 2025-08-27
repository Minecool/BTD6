namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AmmoBelt", menuName = "BTD6/Behaviors/Towers/AmmoBelt")]
public class AmmoBelt : TowerBehavior
{
	public int startCount; //Field offset: 0x30
	public int maxCount; //Field offset: 0x34
	public float regenRate; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 147
	}

	public AmmoBelt() { }

	public virtual TowerBehaviorModel get_Def() { }

}

