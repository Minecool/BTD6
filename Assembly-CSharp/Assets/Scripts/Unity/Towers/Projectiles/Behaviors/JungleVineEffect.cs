namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class JungleVineEffect : ProjectileBehavior
{
	public JungleVineEffect parent; //Field offset: 0x88
	public GameObject displayFront; //Field offset: 0x90
	public GameObject expDisplayFront; //Field offset: 0x98
	public GameObject displayBack; //Field offset: 0xA0
	public GameObject expDisplayBack; //Field offset: 0xA8
	public AudioClip sound1; //Field offset: 0xB0
	public AudioClip expSound1; //Field offset: 0xB8
	public AudioClip sound2; //Field offset: 0xC0
	public AudioClip expSound2; //Field offset: 0xC8
	public AudioClip sound3; //Field offset: 0xD0
	public AudioClip expSound3; //Field offset: 0xD8
	public AudioClip sound4; //Field offset: 0xE0
	public AudioClip expSound4; //Field offset: 0xE8
	public Fullscreen fullscreen; //Field offset: 0xF0
	public string expFullscreen; //Field offset: 0xF8
	public float destroyAfterPopTime; //Field offset: 0x100
	public string expDestroyAfterPopTime; //Field offset: 0x108

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 945
	}

	public JungleVineEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

