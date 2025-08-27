namespace Assets.Scripts.Data.Bloons;

[CreateAssetMenu(fileName = "New Bloon Immune Sound", menuName = "BTD6/Bloon Immune Sound", order = 1)]
public class BloonImmuneSoundScriptable : ScriptableObject
{
	internal class BloonImmuneSound
	{
		[SerializeField]
		public AudioClipReference[] sounds; //Field offset: 0x10
		[SerializeField]
		public string soundEffectGroupID; //Field offset: 0x18
		[SerializeField]
		public int soundEffectGroupLimit; //Field offset: 0x20
		[SerializeField]
		public int soundEffectGroupLimitCounter; //Field offset: 0x24

		public BloonImmuneSound() { }

	}

	[SerializableDictionary]
	[SerializeField]
	public SerializableDictionary<BloonProperties, BloonImmuneSound> immuneSounds; //Field offset: 0x18
	[SerializableDictionary]
	[SerializeField]
	public SerializableDictionary<TowerSet, BloonImmuneSound> towerSetImmuneSounds; //Field offset: 0x20

	public BloonImmuneSoundScriptable() { }

}

