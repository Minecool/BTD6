namespace GestureSystem;

public class CustomButton : Button
{
	private static Dictionary<String, List`1<CustomButton>> buttonGroups; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsClickable>k__BackingField; //Field offset: 0x108
	public UnityEvent onPointerEnter; //Field offset: 0x110
	public UnityEvent onPointerExit; //Field offset: 0x118
	public UnityEvent onPointerDown; //Field offset: 0x120
	public UnityEvent onPointerUp; //Field offset: 0x128
	protected GameObject active; //Field offset: 0x130
	protected GameObject inactive; //Field offset: 0x138
	protected GameObject locked; //Field offset: 0x140
	protected GameObject highlighted; //Field offset: 0x148
	private string groupId; //Field offset: 0x150
	[CompilerGenerated]
	private bool <IsFocused>k__BackingField; //Field offset: 0x158

	public bool IsClickable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private bool IsFocused
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private static CustomButton() { }

	public CustomButton() { }

	public void AddToGroup(string groupId) { }

	protected virtual void Awake() { }

	public void Click() { }

	[CompilerGenerated]
	public bool get_IsClickable() { }

	[CompilerGenerated]
	public bool get_IsFocused() { }

	public override bool IsEnabled() { }

	protected virtual void OnDestroy() { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	[CompilerGenerated]
	protected void set_IsClickable(bool value) { }

	[CompilerGenerated]
	private void set_IsFocused(bool value) { }

	public override void SetEnabled(bool enabled) { }

	public void SetLocked(bool isLocked) { }

}

