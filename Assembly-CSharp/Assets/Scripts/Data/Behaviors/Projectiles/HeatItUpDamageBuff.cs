namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "HeatItUpDamageBuff", menuName = "BTD6/Behaviors/Projectiles/HeatItUpDamageBuff")]
public class HeatItUpDamageBuff : ProjectileBehavior
{
	public float lifespan; //Field offset: 0x30
	public string mutatorId; //Field offset: 0x38
	public bool useTowerPosition; //Field offset: 0x40
	public string buffLocsName; //Field offset: 0x48
	public string buffIconName; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 177
	}

	public HeatItUpDamageBuff() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

