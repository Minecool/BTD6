namespace Assets.Scripts.Unity.GeraldoItems;

public class RejuvPotionBehavior : GeraldoItemBehavior
{
	[SerializeField]
	private int livesGained; //Field offset: 0x10
	[SerializeField]
	private PrefabReference textDisplay; //Field offset: 0x18
	[SerializeField]
	private float textDisplayLifespan; //Field offset: 0x20

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public RejuvPotionBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

