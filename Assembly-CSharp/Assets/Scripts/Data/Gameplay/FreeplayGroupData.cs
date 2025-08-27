namespace Assets.Scripts.Data.Gameplay;

[CreateAssetMenu(menuName = "BTD6/Freeplay Group Data")]
public class FreeplayGroupData : ScriptableObject
{
	public FreeplayGroupDataItem[] items; //Field offset: 0x18

	public FreeplayGroupData() { }

}

