namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class HeatItUpDamageBuff : ProjectileBehavior
{
	public HeatItUpDamageBuff parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public string mutatorId; //Field offset: 0xA0
	public string expMutatorId; //Field offset: 0xA8
	public bool useTowerPosition; //Field offset: 0xB0
	public string expUseTowerPosition; //Field offset: 0xB8
	public string buffLocsName; //Field offset: 0xC0
	public string expBuffLocsName; //Field offset: 0xC8
	public string buffIconName; //Field offset: 0xD0
	public string expBuffIconName; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 192
	}

	public HeatItUpDamageBuff() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

