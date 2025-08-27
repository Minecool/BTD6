//Type is in global namespace

public class PlayEffectOnClick : OnClickHandler
{
	public object effect; //Field offset: 0x50
	private List<ParticleSystem> particles; //Field offset: 0x58

	public PlayEffectOnClick() { }

	private ParticleSystem GetInactiveEffect() { }

	public virtual void OnActivate() { }

}

