namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SubmergeEffect", menuName = "BTD6/Behaviors/Towers/SubmergeEffect")]
public class SubmergeEffect : TowerBehavior
{
	public Effect effect; //Field offset: 0x30
	public Projectile projectile; //Field offset: 0x38
	public float displayRadius; //Field offset: 0x40
	public Tower tower; //Field offset: 0x48

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 259
	}

	public SubmergeEffect() { }

	public virtual TowerBehaviorModel get_Def() { }

}

