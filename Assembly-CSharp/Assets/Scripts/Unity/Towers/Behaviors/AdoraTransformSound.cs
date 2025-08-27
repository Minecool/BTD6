namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AdoraTransformSound : TowerBehavior
{
	public AdoraTransformSound parent; //Field offset: 0x98
	public AudioClip newSelectSound01; //Field offset: 0xA0
	public AudioClip newSelectSound02; //Field offset: 0xA8
	public AudioClip newSelectSound03; //Field offset: 0xB0
	public AudioClip newSelectSound04; //Field offset: 0xB8
	public AudioClip newSelectSound05; //Field offset: 0xC0
	public AudioClip newSelectSound06; //Field offset: 0xC8
	public AudioClip newSelectAltSound01; //Field offset: 0xD0
	public AudioClip newSelectAltSound02; //Field offset: 0xD8
	public AudioClip newLeakSound01; //Field offset: 0xE0
	public AudioClip newLeakSound02; //Field offset: 0xE8
	public AudioClip newMoabDestroyedSound01; //Field offset: 0xF0
	public AudioClip newMoabDestroyedSound02; //Field offset: 0xF8
	public AudioClip newMoabWarningSound; //Field offset: 0x100
	public AudioClip newBfbWarningSound; //Field offset: 0x108
	public AudioClip newZomgWarningSound; //Field offset: 0x110
	public AudioClip newDdtWarningSound; //Field offset: 0x118
	public AudioClip newBadWarningSound; //Field offset: 0x120
	public AudioClip newUltimate3Sound; //Field offset: 0x128
	public AudioClip newUltimate7Sound; //Field offset: 0x130
	public AudioClip newUltimate10Sound; //Field offset: 0x138
	public AudioClip transformSound; //Field offset: 0x140

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 3829
	}

	public AdoraTransformSound() { }

	public virtual TowerBehaviorModel get_Def() { }

}

