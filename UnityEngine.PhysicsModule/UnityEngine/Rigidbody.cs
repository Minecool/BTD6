namespace UnityEngine;

[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component
{

	public float angularDamping
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.angularDamping instead. (UnityUpgradable) -> angularDamping")]
	public float angularDrag
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Vector3 angularVelocity
	{
		 get { } //Length: 144
		 set { } //Length: 133
	}

	public bool automaticCenterOfMass
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool automaticInertiaTensor
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Vector3 centerOfMass
	{
		 get { } //Length: 144
		 set { } //Length: 133
	}

	public CollisionDetectionMode collisionDetectionMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public RigidbodyConstraints constraints
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public bool detectCollisions
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.linearDamping instead. (UnityUpgradable) -> linearDamping")]
	public float drag
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public LayerMask excludeLayers
	{
		 get { } //Length: 135
		 set { } //Length: 126
	}

	public bool freezeRotation
	{
		 get { } //Length: 126
		 set { } //Length: 373
	}

	public LayerMask includeLayers
	{
		 get { } //Length: 135
		 set { } //Length: 126
	}

	public Vector3 inertiaTensor
	{
		 get { } //Length: 144
		 set { } //Length: 133
	}

	public Quaternion inertiaTensorRotation
	{
		 get { } //Length: 142
		 set { } //Length: 133
	}

	public RigidbodyInterpolation interpolation
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public bool isKinematic
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float linearDamping
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Vector3 linearVelocity
	{
		 get { } //Length: 144
		 set { } //Length: 133
	}

	public float mass
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float maxAngularVelocity
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float maxDepenetrationVelocity
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float maxLinearVelocity
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Vector3 position
	{
		 get { } //Length: 144
		 set { } //Length: 133
	}

	public Quaternion rotation
	{
		 get { } //Length: 142
		 set { } //Length: 133
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("The sleepAngularVelocity is no longer supported. Use sleepThreshold to specify energy.", True)]
	public float sleepAngularVelocity
	{
		 get { } //Length: 6
		 set { } //Length: 3
	}

	public float sleepThreshold
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.", True)]
	public float sleepVelocity
	{
		 get { } //Length: 6
		 set { } //Length: 3
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.solverIterations instead. (UnityUpgradable) -> solverIterations", True)]
	public int solverIterationCount
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public int solverIterations
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.solverVelocityIterations instead. (UnityUpgradable) -> solverVelocityIterations", True)]
	public int solverVelocityIterationCount
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public int solverVelocityIterations
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Cone friction is no longer supported.", True)]
	public bool useConeFriction
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public bool useGravity
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use Rigidbody.linearVelocity instead. (UnityUpgradable) -> linearVelocity")]
	public Vector3 velocity
	{
		 get { } //Length: 166
		 set { } //Length: 140
	}

	public Vector3 worldCenterOfMass
	{
		 get { } //Length: 144
	}

	internal Matrix4x4 worldInertiaTensorMatrix
	{
		internal get { } //Length: 154
	}

	public Rigidbody() { }

	[ExcludeFromDocs]
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) { }

	private static void AddExplosionForce_Injected(IntPtr _unity_self, float explosionForce, in Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddForce(Vector3 force) { }

	public void AddForce(Vector3 force, ForceMode mode) { }

	public void AddForce(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddForce(float x, float y, float z) { }

	private static void AddForce_Injected(IntPtr _unity_self, in Vector3 force, ForceMode mode) { }

	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddForceAtPosition(Vector3 force, Vector3 position) { }

	private static void AddForceAtPosition_Injected(IntPtr _unity_self, in Vector3 force, in Vector3 position, ForceMode mode) { }

	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddRelativeForce(Vector3 force) { }

	public void AddRelativeForce(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddRelativeForce(float x, float y, float z) { }

	private static void AddRelativeForce_Injected(IntPtr _unity_self, in Vector3 force, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddRelativeTorque(float x, float y, float z) { }

	public void AddRelativeTorque(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddRelativeTorque(Vector3 torque) { }

	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	private static void AddRelativeTorque_Injected(IntPtr _unity_self, in Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddTorque(Vector3 torque) { }

	public void AddTorque(Vector3 torque, ForceMode mode) { }

	public void AddTorque(float x, float y, float z, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddTorque(float x, float y, float z) { }

	private static void AddTorque_Injected(IntPtr _unity_self, in Vector3 torque, ForceMode mode) { }

	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	public float get_angularDamping() { }

	private static float get_angularDamping_Injected(IntPtr _unity_self) { }

	public float get_angularDrag() { }

	public Vector3 get_angularVelocity() { }

	private static void get_angularVelocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public bool get_automaticCenterOfMass() { }

	private static bool get_automaticCenterOfMass_Injected(IntPtr _unity_self) { }

	public bool get_automaticInertiaTensor() { }

	private static bool get_automaticInertiaTensor_Injected(IntPtr _unity_self) { }

	public Vector3 get_centerOfMass() { }

	private static void get_centerOfMass_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public CollisionDetectionMode get_collisionDetectionMode() { }

	private static CollisionDetectionMode get_collisionDetectionMode_Injected(IntPtr _unity_self) { }

	public RigidbodyConstraints get_constraints() { }

	private static RigidbodyConstraints get_constraints_Injected(IntPtr _unity_self) { }

	public bool get_detectCollisions() { }

	private static bool get_detectCollisions_Injected(IntPtr _unity_self) { }

	public float get_drag() { }

	public LayerMask get_excludeLayers() { }

	private static void get_excludeLayers_Injected(IntPtr _unity_self, out LayerMask ret) { }

	public bool get_freezeRotation() { }

	public LayerMask get_includeLayers() { }

	private static void get_includeLayers_Injected(IntPtr _unity_self, out LayerMask ret) { }

	public Vector3 get_inertiaTensor() { }

	private static void get_inertiaTensor_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Quaternion get_inertiaTensorRotation() { }

	private static void get_inertiaTensorRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	public RigidbodyInterpolation get_interpolation() { }

	private static RigidbodyInterpolation get_interpolation_Injected(IntPtr _unity_self) { }

	public bool get_isKinematic() { }

	private static bool get_isKinematic_Injected(IntPtr _unity_self) { }

	public float get_linearDamping() { }

	private static float get_linearDamping_Injected(IntPtr _unity_self) { }

	public Vector3 get_linearVelocity() { }

	private static void get_linearVelocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public float get_mass() { }

	private static float get_mass_Injected(IntPtr _unity_self) { }

	public float get_maxAngularVelocity() { }

	private static float get_maxAngularVelocity_Injected(IntPtr _unity_self) { }

	public float get_maxDepenetrationVelocity() { }

	private static float get_maxDepenetrationVelocity_Injected(IntPtr _unity_self) { }

	public float get_maxLinearVelocity() { }

	private static float get_maxLinearVelocity_Injected(IntPtr _unity_self) { }

	public Vector3 get_position() { }

	private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Quaternion get_rotation() { }

	private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	public float get_sleepAngularVelocity() { }

	public float get_sleepThreshold() { }

	private static float get_sleepThreshold_Injected(IntPtr _unity_self) { }

	public float get_sleepVelocity() { }

	public int get_solverIterationCount() { }

	public int get_solverIterations() { }

	private static int get_solverIterations_Injected(IntPtr _unity_self) { }

	public int get_solverVelocityIterationCount() { }

	public int get_solverVelocityIterations() { }

	private static int get_solverVelocityIterations_Injected(IntPtr _unity_self) { }

	public bool get_useConeFriction() { }

	public bool get_useGravity() { }

	private static bool get_useGravity_Injected(IntPtr _unity_self) { }

	public Vector3 get_velocity() { }

	public Vector3 get_worldCenterOfMass() { }

	private static void get_worldCenterOfMass_Injected(IntPtr _unity_self, out Vector3 ret) { }

	internal Matrix4x4 get_worldInertiaTensorMatrix() { }

	private static void get_worldInertiaTensorMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	public Vector3 GetAccumulatedForce(float step) { }

	[ExcludeFromDocs]
	public Vector3 GetAccumulatedForce() { }

	private static void GetAccumulatedForce_Injected(IntPtr _unity_self, float step, out Vector3 ret) { }

	public Vector3 GetAccumulatedTorque(float step) { }

	[ExcludeFromDocs]
	public Vector3 GetAccumulatedTorque() { }

	private static void GetAccumulatedTorque_Injected(IntPtr _unity_self, float step, out Vector3 ret) { }

	public Vector3 GetPointVelocity(Vector3 worldPoint) { }

	private static void GetPointVelocity_Injected(IntPtr _unity_self, in Vector3 worldPoint, out Vector3 ret) { }

	public Vector3 GetRelativePointVelocity(Vector3 relativePoint) { }

	private static void GetRelativePointVelocity_Injected(IntPtr _unity_self, in Vector3 relativePoint, out Vector3 ret) { }

	[NativeName("ClosestPointOnBounds")]
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	private static void Internal_ClosestPointOnBounds_Injected(IntPtr _unity_self, in Vector3 point, ref Vector3 outPos, ref float distance) { }

	[NativeName("SweepTestAll")]
	private RaycastHit[] Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	private static void Internal_SweepTestAll_Injected(IntPtr _unity_self, in Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret) { }

	public bool IsSleeping() { }

	private static bool IsSleeping_Injected(IntPtr _unity_self) { }

	public void Move(Vector3 position, Quaternion rotation) { }

	private static void Move_Injected(IntPtr _unity_self, in Vector3 position, in Quaternion rotation) { }

	public void MovePosition(Vector3 position) { }

	private static void MovePosition_Injected(IntPtr _unity_self, in Vector3 position) { }

	public void MoveRotation(Quaternion rot) { }

	private static void MoveRotation_Injected(IntPtr _unity_self, in Quaternion rot) { }

	public void PublishTransform() { }

	private static void PublishTransform_Injected(IntPtr _unity_self) { }

	public void ResetCenterOfMass() { }

	private static void ResetCenterOfMass_Injected(IntPtr _unity_self) { }

	public void ResetInertiaTensor() { }

	private static void ResetInertiaTensor_Injected(IntPtr _unity_self) { }

	public void set_angularDamping(float value) { }

	private static void set_angularDamping_Injected(IntPtr _unity_self, float value) { }

	public void set_angularDrag(float value) { }

	public void set_angularVelocity(Vector3 value) { }

	private static void set_angularVelocity_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_automaticCenterOfMass(bool value) { }

	private static void set_automaticCenterOfMass_Injected(IntPtr _unity_self, bool value) { }

	public void set_automaticInertiaTensor(bool value) { }

	private static void set_automaticInertiaTensor_Injected(IntPtr _unity_self, bool value) { }

	public void set_centerOfMass(Vector3 value) { }

	private static void set_centerOfMass_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	private static void set_collisionDetectionMode_Injected(IntPtr _unity_self, CollisionDetectionMode value) { }

	public void set_constraints(RigidbodyConstraints value) { }

	private static void set_constraints_Injected(IntPtr _unity_self, RigidbodyConstraints value) { }

	public void set_detectCollisions(bool value) { }

	private static void set_detectCollisions_Injected(IntPtr _unity_self, bool value) { }

	public void set_drag(float value) { }

	public void set_excludeLayers(LayerMask value) { }

	private static void set_excludeLayers_Injected(IntPtr _unity_self, in LayerMask value) { }

	public void set_freezeRotation(bool value) { }

	public void set_includeLayers(LayerMask value) { }

	private static void set_includeLayers_Injected(IntPtr _unity_self, in LayerMask value) { }

	public void set_inertiaTensor(Vector3 value) { }

	private static void set_inertiaTensor_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_inertiaTensorRotation(Quaternion value) { }

	private static void set_inertiaTensorRotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	public void set_interpolation(RigidbodyInterpolation value) { }

	private static void set_interpolation_Injected(IntPtr _unity_self, RigidbodyInterpolation value) { }

	public void set_isKinematic(bool value) { }

	private static void set_isKinematic_Injected(IntPtr _unity_self, bool value) { }

	public void set_linearDamping(float value) { }

	private static void set_linearDamping_Injected(IntPtr _unity_self, float value) { }

	public void set_linearVelocity(Vector3 value) { }

	private static void set_linearVelocity_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_mass(float value) { }

	private static void set_mass_Injected(IntPtr _unity_self, float value) { }

	public void set_maxAngularVelocity(float value) { }

	private static void set_maxAngularVelocity_Injected(IntPtr _unity_self, float value) { }

	public void set_maxDepenetrationVelocity(float value) { }

	private static void set_maxDepenetrationVelocity_Injected(IntPtr _unity_self, float value) { }

	public void set_maxLinearVelocity(float value) { }

	private static void set_maxLinearVelocity_Injected(IntPtr _unity_self, float value) { }

	public void set_position(Vector3 value) { }

	private static void set_position_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private static void set_rotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	public void set_sleepAngularVelocity(float value) { }

	public void set_sleepThreshold(float value) { }

	private static void set_sleepThreshold_Injected(IntPtr _unity_self, float value) { }

	public void set_sleepVelocity(float value) { }

	public void set_solverIterationCount(int value) { }

	public void set_solverIterations(int value) { }

	private static void set_solverIterations_Injected(IntPtr _unity_self, int value) { }

	public void set_solverVelocityIterationCount(int value) { }

	public void set_solverVelocityIterations(int value) { }

	private static void set_solverVelocityIterations_Injected(IntPtr _unity_self, int value) { }

	public void set_useConeFriction(bool value) { }

	public void set_useGravity(bool value) { }

	private static void set_useGravity_Injected(IntPtr _unity_self, bool value) { }

	public void set_velocity(Vector3 value) { }

	public void SetDensity(float density) { }

	private static void SetDensity_Injected(IntPtr _unity_self, float density) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use Rigidbody.maxAngularVelocity instead.")]
	public void SetMaxAngularVelocity(float a) { }

	public void Sleep() { }

	private static void Sleep_Injected(IntPtr _unity_self) { }

	private RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit) { }

	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocs]
	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo) { }

	private static void SweepTest_Injected(IntPtr _unity_self, in Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret) { }

	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocs]
	public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance) { }

	[ExcludeFromDocs]
	public RaycastHit[] SweepTestAll(Vector3 direction) { }

	public void WakeUp() { }

	private static void WakeUp_Injected(IntPtr _unity_self) { }

}

