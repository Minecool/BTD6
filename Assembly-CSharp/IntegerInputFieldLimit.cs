//Type is in global namespace

public class IntegerInputFieldLimit : MonoBehaviour
{
	public int minValue; //Field offset: 0x20
	public int maxValue; //Field offset: 0x24
	private TMP_InputField inputField; //Field offset: 0x28

	public IntegerInputFieldLimit() { }

	private void OnValueSubmitted(string value) { }

	private void Start() { }

}

