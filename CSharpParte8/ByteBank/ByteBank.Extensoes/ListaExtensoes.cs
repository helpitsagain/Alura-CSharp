using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Extensoes
{
    public static class ListaExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
		{
			foreach (T item in itens)
			{
				lista.Add(item);
			}
		}
    }
}