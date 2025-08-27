namespace Assets.Scripts.Data;

[CreateAssetMenu(menuName = "BTD6/TowerSnappingData")]
public class TowerSnappingData : ScriptableObject
{
	public float towerSnappingDistance; //Field offset: 0x18
	public AudioClipReference snapSound; //Field offset: 0x20

	public TowerSnappingData() { }

}

