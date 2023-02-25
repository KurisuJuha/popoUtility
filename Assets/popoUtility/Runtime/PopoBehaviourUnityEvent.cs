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
    }
}