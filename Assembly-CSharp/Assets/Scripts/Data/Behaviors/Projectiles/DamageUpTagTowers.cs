namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DamageUpTagTowers", menuName = "BTD6/Behaviors/Projectiles/DamageUpTagTowers")]
public class DamageUpTagTowers : ProjectileBehavior
{
	public int increase; //Field offset: 0x30
	public string bloonTag; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40
	public bool useClosest; //Field offset: 0x44
	public string mutatorId; //Field offset: 0x48
	public float priority; //Field offset: 0x50
	public bool useTowerPosition; //Field offset: 0x54

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 218
	}

	public DamageUpTagTowers() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

