namespace Assets.Scripts.Unity.Gamepad.InputSystem;

public class FakeSelectable : MultiplayerSelectable
{

	public FakeSelectable() { }

	public static FakeSelectable Register(GameObject gameObject, bool canNav, RectTransform rtRaycastTarget = null) { }

	public static FakeSelectable Register(Transform t, bool canNav, RectTransform rt = null) { }

	protected void Start() { }

}

