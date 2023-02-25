namespace JuhaKurisu.PopoTools.Utility
{
    public abstract partial class PopoBehaviour
    {
        public float positionX
        {
            get => transform.position.x;
            set => transform.position = new(value, positionY, positionZ);
        }

        public float positionY
        {
            get => transform.position.y;
            set => transform.position = new(positionX, value, positionZ);
        }

        public float positionZ
        {
            get => transform.position.z;
            set => transform.position = new(positionX, positionY, value);
        }
    }
}