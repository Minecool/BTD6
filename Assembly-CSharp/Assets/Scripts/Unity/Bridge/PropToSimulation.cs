namespace Assets.Scripts.Unity.Bridge;

public class PropToSimulation : Selectable
{
	private PropBase prop; //Field offset: 0x10
	private bool destroyed; //Field offset: 0x18
	private ObjectId Id; //Field offset: 0x1C
	public Action OnDestroyed; //Field offset: 0x20
	public Action OnSelectionDisabled; //Field offset: 0x28

	public long CashEarned
	{
		 get { } //Length: 30
	}

	public long DamageDealt
	{
		 get { } //Length: 30
	}

	public PropModel Def
	{
		 get { } //Length: 30
	}

	public int GroupLayer
	{
		 get { } //Length: 29
	}

	public bool HasAnimatorComponent
	{
		 get { } //Length: 29
	}

	public bool HasSightAndPlacementBlockingAreas
	{
		 get { } //Length: 42
	}

	public float HeightOffset
	{
		 get { } //Length: 40
	}

	public virtual ObjectId id
	{
		 get { } //Length: 4
	}

	public bool IsAnimating
	{
		 get { } //Length: 29
	}

	public bool IsDestroyed
	{
		 get { } //Length: 5
	}

	public bool IsRemoveableProp
	{
		 get { } //Length: 42
	}

	public bool IsSelectable
	{
		 get { } //Length: 29
	}

	public bool IsSightAndPlacementBlockingActive
	{
		 get { } //Length: 33
	}

	public bool IsSpecialEffectProp
	{
		 get { } //Length: 42
	}

	public int Owner
	{
		 get { } //Length: 63
	}

	public Vector3 Position
	{
		 get { } //Length: 214
	}

	public Vector3 Rotation
	{
		 get { } //Length: 47
	}

	public Vector3 Scale
	{
		 get { } //Length: 219
	}

	public TargetType TargetType
	{
		 get { } //Length: 95
	}

	public float Worth
	{
		 get { } //Length: 31
	}

	public PropToSimulation(PropBase prop) { }

	public void Destroy() { }

	public long get_CashEarned() { }

	public long get_DamageDealt() { }

	public PropModel get_Def() { }

	public int get_GroupLayer() { }

	public bool get_HasAnimatorComponent() { }

	public bool get_HasSightAndPlacementBlockingAreas() { }

	public float get_HeightOffset() { }

	public virtual ObjectId get_id() { }

	public bool get_IsAnimating() { }

	public bool get_IsDestroyed() { }

	public bool get_IsRemoveableProp() { }

	public bool get_IsSelectable() { }

	public bool get_IsSightAndPlacementBlockingActive() { }

	public bool get_IsSpecialEffectProp() { }

	public int get_Owner() { }

	public Vector3 get_Position() { }

	public Vector3 get_Rotation() { }

	public Vector3 get_Scale() { }

	public TargetType get_TargetType() { }

	public float get_Worth() { }

	public PropBase GetSimProp() { }

	public void PitchProp(float value) { }

	public void RaiseLowerProp(float value) { }

	public void RollProp(float value) { }

	public void ScaleProp(float value) { }

	public void SelectableDisabled() { }

	public void TogglePropAnimation(bool isOn) { }

	public void ToggleSightAndPlacementBlocking(bool isOn) { }

	public void TriggerPlacementAnimation() { }

	public void YawProp(float value) { }

}

