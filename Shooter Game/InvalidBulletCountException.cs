using System.Runtime.Serialization;

namespace Shooter_Game
{
    [Serializable]
    internal class InvalidBulletCountException : Exception
    {
        public InvalidBulletCountException()
        {
        }

        public InvalidBulletCountException(string? message) : base(message)
        {
        }

        public InvalidBulletCountException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidBulletCountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}