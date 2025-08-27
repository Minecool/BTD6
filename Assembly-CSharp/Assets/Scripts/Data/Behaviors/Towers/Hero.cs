namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "Hero", menuName = "BTD6/Behaviors/Towers/Hero")]
public class Hero : TowerBehavior
{
	public float xpScale; //Field offset: 0x30
	public float costPerXpToLevel; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public Hero() { }

	public virtual TowerBehaviorModel get_Def() { }

}

