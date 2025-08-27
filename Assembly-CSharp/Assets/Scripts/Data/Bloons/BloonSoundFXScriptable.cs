namespace Assets.Scripts.Data.Bloons;

[CreateAssetMenu(fileName = "New Bloon Sound FX", menuName = "BTD6/Bloon Sounds FX", order = 1)]
public class BloonSoundFXScriptable : ScriptableObject
{
	[SerializeField]
	private PrefabReference popFX; //Field offset: 0x18
	[SerializeField]
	private AudioClipReference soundFX1; //Field offset: 0x20
	[SerializeField]
	private AudioClipReference soundFX2; //Field offset: 0x28
	[SerializeField]
	private AudioClipReference soundFX3; //Field offset: 0x30
	[SerializeField]
	private AudioClipReference soundFX4; //Field offset: 0x38
	[SerializeField]
	private string soundFXGroupID; //Field offset: 0x40
	[SerializeField]
	private int soundFXGroupLimit; //Field offset: 0x48
	[SerializeField]
	private int soundFXTimeDelay; //Field offset: 0x4C
	[SerializeField]
	private int soundFXTimeDelayFF; //Field offset: 0x50

	public BloonSoundFXScriptable() { }

	public Model Def() { }

}

