namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnSelected : TowerBehavior
{
	internal enum SpecificHero
	{
		HeroSelectSound = 0,
		GeraldoSelectSound = 1,
		BrickellSelectSound = 2,
		AdoraSelectSound = 3,
	}

	private const int normalDelay = 60; //Field offset: 0x0
	private const int altDelay = 120; //Field offset: 0x0
	public CreateSoundOnSelectedModel createSoundOnSelectedModel; //Field offset: 0x68
	private int selectTimer; //Field offset: 0x70
	private int selectCounter; //Field offset: 0x74
	private bool timerOn; //Field offset: 0x78

	public CreateSoundOnSelected() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnSelectionChanged(ISelectable selectableObject) { }

	private void PlayAltSelectSound(bool isSpecificHero, int track = 1) { }

	private void PlaySelectSound(bool isSpecificHero) { }

	private void Process(int elapsed) { }

	private void TowerDeSelected() { }

	private void TowerSelected() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

