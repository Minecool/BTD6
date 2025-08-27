namespace Assets.Scripts.Unity.Map.Triggers;

public class PlayEffectAction : MapUnityAction
{
	public ParticleSystem[] particles; //Field offset: 0x28
	public double delay; //Field offset: 0x30
	private int currentFrame; //Field offset: 0x38
	private bool effectPlayed; //Field offset: 0x3C
	private bool triggered; //Field offset: 0x3D

	public PlayEffectAction() { }

	public virtual void GotoPostAction() { }

	public virtual void PerformAction() { }

	private void PlayParticleEffects() { }

	public virtual void SetToOriginalState(bool mapEventActive) { }

	private void Start() { }

	private void Update() { }

}

