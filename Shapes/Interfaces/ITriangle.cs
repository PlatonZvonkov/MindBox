namespace Shapes.Interfaces
{
    public interface ITriangle : IShape
    {
        /// <summary>
        /// If it is Right Triangle returns "true"
        /// </summary>
        public bool IsRight { get; }
    }
}
