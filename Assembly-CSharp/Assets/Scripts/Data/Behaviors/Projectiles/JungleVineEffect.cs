namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "JungleVineEffect", menuName = "BTD6/Behaviors/Projectiles/JungleVineEffect")]
public class JungleVineEffect : ProjectileBehavior
{
	public PrefabReference displayFront; //Field offset: 0x30
	public PrefabReference displayBack; //Field offset: 0x38
	public Sound sound1; //Field offset: 0x40
	public Sound sound2; //Field offset: 0x48
	public Sound sound3; //Field offset: 0x50
	public Sound sound4; //Field offset: 0x58
	public Fullscreen fullscreen; //Field offset: 0x60
	public float destroyAfterPopTime; //Field offset: 0x64

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 370
	}

	public JungleVineEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

