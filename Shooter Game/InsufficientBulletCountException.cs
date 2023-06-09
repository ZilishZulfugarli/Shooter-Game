using System.Runtime.Serialization;

namespace Shooter_Game
{
    [Serializable]
    internal class InsufficientBulletCountException : Exception
    {
        public InsufficientBulletCountException()
        {
        }

        public InsufficientBulletCountException(string? message) : base(message)
        {
        }

        public InsufficientBulletCountException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InsufficientBulletCountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}