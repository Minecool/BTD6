namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "TowerExpire", menuName = "BTD6/Behaviors/Towers/TowerExpire")]
public class TowerExpire : TowerBehavior
{
	public float lifespan; //Field offset: 0x30
	public int rounds; //Field offset: 0x34
	public bool expireOnRoundComplete; //Field offset: 0x38
	public bool expireOnDefeatScreen; //Field offset: 0x39

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 167
	}

	public TowerExpire() { }

	public virtual TowerBehaviorModel get_Def() { }

}

