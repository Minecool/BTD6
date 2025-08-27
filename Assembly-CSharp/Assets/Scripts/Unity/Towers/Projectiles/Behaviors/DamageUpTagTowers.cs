namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamageUpTagTowers : ProjectileBehavior
{
	public DamageUpTagTowers parent; //Field offset: 0x88
	public int increase; //Field offset: 0x90
	public string expIncrease; //Field offset: 0x98
	public string bloonTag; //Field offset: 0xA0
	public string expBloonTag; //Field offset: 0xA8
	public float lifespan; //Field offset: 0xB0
	public string expLifespan; //Field offset: 0xB8
	public bool useClosest; //Field offset: 0xC0
	public string expUseClosest; //Field offset: 0xC8
	public string mutatorId; //Field offset: 0xD0
	public string expMutatorId; //Field offset: 0xD8
	public float priority; //Field offset: 0xE0
	public string expPriority; //Field offset: 0xE8
	public bool useTowerPosition; //Field offset: 0xF0
	public string expUseTowerPosition; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 239
	}

	public DamageUpTagTowers() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

