namespace Assets.Scripts.Data.Input;

[CreateAssetMenu(menuName = "BTD6/Gamepad Data")]
public class GamepadData : ScriptableObject
{
	public SelectableMeshConfig selectableMeshConfig; //Field offset: 0x18
	public SolidShadowConfig solidShadowConfig; //Field offset: 0x20
	[Header("Gamepad Icons")]
	[SerializableDictionary]
	[SerializeField]
	private SerializableDictionary<GamepadInputType, SpriteReference> xboxIcons; //Field offset: 0x28
	[SerializableDictionary]
	[SerializeField]
	private SerializableDictionary<GamepadInputType, SpriteReference> playstationIcons; //Field offset: 0x30
	[SerializableDictionary]
	[SerializeField]
	private SerializableDictionary<GamepadInputType, SpriteReference> switchIcons; //Field offset: 0x38

	public GamepadData() { }

	public SpriteReference GetButtonSpriteRef(GamepadInputType type, ControllerType controllerType) { }

}

