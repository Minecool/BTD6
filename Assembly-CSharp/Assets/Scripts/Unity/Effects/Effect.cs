namespace Assets.Scripts.Unity.Effects;

public class Effect : CascadingItemProxy
{
	public Effect parent; //Field offset: 0x88
	public GameObject display; //Field offset: 0x90
	public GameObject expDisplay; //Field offset: 0x98
	public PrefabReference optionalDisplayPrefabRef; //Field offset: 0xA0
	public PrefabReference expOptionalDisplayPrefabRef; //Field offset: 0xA8
	public float scale; //Field offset: 0xB0
	public string expScale; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8
	public Fullscreen fullscreen; //Field offset: 0xD0
	public string expFullscreen; //Field offset: 0xD8
	public bool useCenterPosition; //Field offset: 0xE0
	public string expUseCenterPosition; //Field offset: 0xE8
	public bool useTransformPosition; //Field offset: 0xF0
	public string expUseTransformPosition; //Field offset: 0xF8
	public bool useTransfromRotation; //Field offset: 0x100
	public string expUseTransfromRotation; //Field offset: 0x108
	public bool destroyOnTransformDestroy; //Field offset: 0x110
	public string expDestroyOnTransformDestroy; //Field offset: 0x118
	public bool alwaysUseAge; //Field offset: 0x120
	public string expAlwaysUseAge; //Field offset: 0x128
	public bool useRoundTime; //Field offset: 0x130
	public string expUseRoundTime; //Field offset: 0x138

	public EffectModel Def
	{
		 get { } //Length: 649
	}

	public virtual Model Model
	{
		 get { } //Length: 7
	}

	public Effect() { }

	public EffectModel get_Def() { }

	public virtual Model get_Model() { }

}

