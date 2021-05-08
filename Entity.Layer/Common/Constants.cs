using Entity.Layer.Models;

namespace Entity.Layer.Common
{
    /// <summary>
    /// Constants static class
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// mockOrders object
        /// </summary>
        public static MockOrderDTO[] mockOrders = new MockOrderDTO[]
        {
            new MockOrderDTO { Id = 1, Name = "Order A",  Madeby = "Company A", Type = "Some Type"},
            new MockOrderDTO { Id = 2, Name = "Order A",  Madeby = "Company A", Type = "Some Type"},
            new MockOrderDTO { Id = 3, Name = "Order A",  Madeby = "Company A", Type = "Some Type"},
            new MockOrderDTO { Id = 4, Name = "Order A",  Madeby = "Company A", Type = "Some Type"},
            new MockOrderDTO { Id = 5, Name = "Order A",  Madeby = "Company A", Type = "Some Type"},
            new MockOrderDTO { Id = 6, Name = "Order A",  Madeby = "Company A", Type = "Some Type"},
            new MockOrderDTO { Id = 7, Name = "Order A",  Madeby = "Company A", Type = "Some Type"},
            new MockOrderDTO { Id = 8, Name = "Order A",  Madeby = "Company A", Type = "Some Type"},
            new MockOrderDTO { Id = 9, Name = "Order A",  Madeby = "Company A", Type = "Some Type"},
            new MockOrderDTO { Id = 10, Name = "Order A",  Madeby = "Company A", Type = "Some Type"}
        };
    }
}
