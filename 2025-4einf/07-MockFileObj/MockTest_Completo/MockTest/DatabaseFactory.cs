using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTest
{
    public enum DataBaseType
    {
        /// <summary>
        /// Database basato su file
        /// </summary>
        FileBased,
        /// <summary>
        /// Database basato su liste in memoria
        /// </summary>
        InMemory
    }
    internal static class DatabaseFactory
    {
        /// <summary>
        /// Crea un'istanza di DB del tipo specificato
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static IDatabaseMock CreateDatabase(DataBaseType tipo)
        {
            switch (tipo)
            {
                case DataBaseType.FileBased:
                    return new DatabaseMock();

                case DataBaseType.InMemory:
                    return new DatabaseMockList();

                default:
                    throw new ArgumentException($"Tipo di database non supportato: {tipo}");
            }
        }

        /// <summary>
        /// Creo un DB di default di tipo file
        /// </summary>
        /// <returns></returns>
        public static IDatabaseMock CreateDatabase()
        {
            return new DatabaseMock();
        }
    }
}
