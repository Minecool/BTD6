namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnBloonEnterTrack : TowerBehavior
{
	public CreateSoundOnBloonEnterTrackModel createSoundOnBloonEnterTrackModel; //Field offset: 0x68
	private Dictionary<String, Boolean> playedBloonEnterSoundDictionary; //Field offset: 0x70

	public CreateSoundOnBloonEnterTrack() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnBloonEnterTrack(Bloon bloon) { }

	public virtual void OnRoundStart(int roundNo) { }

	private void PlaySound(string moabType) { }

	private void ResetPlayedBooleans() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

