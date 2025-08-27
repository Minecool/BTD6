namespace Assets.Scripts.Data.Accolades;

[CreateAssetMenu(fileName = "New Accolade", menuName = "BTD6/Accolade", order = 1)]
public class AccoladeData : ScriptableObject
{
	public AccoladeType accoladeType; //Field offset: 0x18
	public PrefabReference smallIcon; //Field offset: 0x20
	public PrefabReference bigIcon; //Field offset: 0x28

	public AccoladeData() { }

}

