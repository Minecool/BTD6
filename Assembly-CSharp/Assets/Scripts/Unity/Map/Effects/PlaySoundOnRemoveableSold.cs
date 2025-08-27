namespace Assets.Scripts.Unity.Map.Effects;

public class PlaySoundOnRemoveableSold : OnRemoveableSold
{
	public PlayInteractableAudio playInteractableAudio; //Field offset: 0x28

	public PlaySoundOnRemoveableSold() { }

	public virtual void PerformAction() { }

}

