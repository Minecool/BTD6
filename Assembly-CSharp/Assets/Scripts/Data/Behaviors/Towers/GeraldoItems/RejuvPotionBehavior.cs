namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "RejuvPotionBehavior", menuName = "BTD6/Behaviors/Towers/GeraldoItems/RejuvPotionBehavior")]
public class RejuvPotionBehavior : GeraldoItemBehavior
{
	public int livesGained; //Field offset: 0x28
	public PrefabReference textDisplay; //Field offset: 0x30
	public float textDisplayLifespan; //Field offset: 0x38

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public RejuvPotionBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

