using UnityEngine;

namespace JuhaKurisu.PopoTools.Utility
{
    public abstract partial class PopoBehaviour : MonoBehaviour
    {
        protected virtual void Awake() { }
        protected virtual void FixedUpdate() { }
        protected virtual void LateUpdate() { }
        protected virtual void OnAnimatorIK(int layerIndex) { }
        protected virtual void OnAnimatorMove() { }
        protected virtual void OnApplicationFocus() { }
        protected virtual void OnApplicationPause(bool pauseStatus) { }
        protected virtual void OnApplicationQuit() { }
        protected virtual void OnAudioFilterRead(float[] data, int channels) { }
        protected virtual void OnBecameInvisible() { }
        protected virtual void OnBecameVisible() { }
        protected virtual void OnCollisionEnter(Collision other) { }
        protected virtual void OnCollisionEnter2D(Collision2D other) { }
        protected virtual void OnCollisionExit(Collision other) { }
        protected virtual void OnCollisionExit2D(Collision2D other) { }
        protected virtual void OnCollisionStay(Collision other) { }
        protected virtual void OnCollisionStay2D(Collision2D other) { }
        protected virtual void OnControllerColliderHit(ControllerColliderHit hit) { }
        protected virtual void OnDestroy() { }
        protected virtual void OnDisable() { }
        protected virtual void OnDrawGizmos() { }
        protected virtual void OnDrawGizmosSelected() { }
        protected virtual void OnEnable() { }
        protected virtual void OnGUI() { }
        protected virtual void OnJointBreak(float breakForce) { }
        protected virtual void OnJointBreak2D(Joint2D brokenJoint) { }
        protected virtual void OnMouseDown() { }
        protected virtual void OnMouseDrag() { }
        protected virtual void OnMouseEnter() { }
        protected virtual void OnMouseExit() { }
        protected virtual void OnMouseOver() { }
        protected virtual void OnMouseUp() { }
        protected virtual void OnMouseUpAsButton() { }
        protected virtual void OnParticleCollision(GameObject other) { }
        protected virtual void OnParticleSystemStopped() { }
        protected virtual void OnParticleTrigger() { }
        protected virtual void OnParticleUpdateJobScheduled() { }
        protected virtual void OnPostRender() { }
        protected virtual void OnPreCull() { }
        protected virtual void OnPreRender() { }
        protected virtual void OnRenderImage(RenderTexture src, RenderTexture dest) { }
        protected virtual void OnRenderObject() { }
        protected virtual void OnTransformChildrenChanged() { }
        protected virtual void OnTransformParentChanged() { }
        protected virtual void OnTriggerEnter(Collider other) { }
        protected virtual void OnTriggerEnter2D(Collider2D other) { }
        protected virtual void OnTriggerExit(Collider other) { }
        protected virtual void OnTriggerExit2D(Collider2D other) { }
        protected virtual void OnTriggerStay(Collider other) { }
        protected virtual void OnTriggerStay2D(Collider2D other) { }
        protected virtual void OnValidate() { }
        protected virtual void OnWillRenderObject() { }
        protected virtual void Reset() { }
        protected virtual void Start() { }
    }
}