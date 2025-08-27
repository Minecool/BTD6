namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicsManager.h")]
[NativeHeader("Modules/Physics/PhysicsQuery.h")]
[StaticAccessor("GetPhysicsManager()", StaticAccessorType::Dot (0))]
public class Physics
{
	internal sealed class ContactEventDelegate : MulticastDelegate
	{

		public ContactEventDelegate(object object, IntPtr method) { }

		public override void Invoke(PhysicsScene scene, ReadOnly<ContactPairHeader> headerArray) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEvent; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<PhysicsScene, NativeArray`1<ModifiableContactPair>> ContactModifyEventCCD; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<PhysicsScene, IntPtr, Int32, Boolean> GenericContactModifyEvent; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ContactEventDelegate ContactEvent; //Field offset: 0x18
	private static readonly Collision s_ReusableCollision; //Field offset: 0x20

	[NativeProperty("DefaultPhysicsSceneHandle", True, TargetType::Function (0), True)]
	public static PhysicsScene defaultPhysicsScene
	{
		 get { } //Length: 108
	}

	public static bool invokeCollisionCallbacks
	{
		 get { } //Length: 42
	}

	public static bool reuseCollisionCallbacks
	{
		 get { } //Length: 42
	}

	public static SimulationMode simulationMode
	{
		 set { } //Length: 49
	}

	private static Physics() { }

	public static PhysicsScene get_defaultPhysicsScene() { }

	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	public static bool get_invokeCollisionCallbacks() { }

	public static bool get_reuseCollisionCallbacks() { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	internal static Component GetBodyByInstanceID(int instanceID) { }

	private static IntPtr GetBodyByInstanceID_Injected(int instanceID) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	private static IntPtr GetColliderByInstanceID_Injected(int instanceID) { }

	private static Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	[FreeFunction("Physics::RaycastAll")]
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	private static void Internal_RaycastAll_Injected(in PhysicsScene physicsScene, in Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret) { }

	[RequiredByNativeCode]
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	[RequiredByNativeCode]
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	private static void PhysXOnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	[ExcludeFromDocs]
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Ray ray) { }

	[ExcludeFromDocs]
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	private static void ReportContacts(ReadOnly<ContactPairHeader> array) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	private static void SendOnCollisionEnter_Injected(IntPtr component, Collision collision) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	private static void SendOnCollisionExit_Injected(IntPtr component, Collision collision) { }

	[StaticAccessor("PhysicsManager", StaticAccessorType::DoubleColon (2))]
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	private static void SendOnCollisionStay_Injected(IntPtr component, Collision collision) { }

	public static void set_simulationMode(SimulationMode value) { }

}

