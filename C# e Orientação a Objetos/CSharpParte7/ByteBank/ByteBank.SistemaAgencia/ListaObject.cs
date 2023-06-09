using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaObject
    {
        private object[] _itens;
		private int _proximaPosicao;
		public int Tamanho { get { return _proximaPosicao; } }

		public ListaObject(int tamanhoInicial = 1)
		{
			_itens = new object[tamanhoInicial];
			_proximaPosicao = 0;
		}

		public void Adicionar(object item)
		{
			VerificarCapacidade(_proximaPosicao + 1);

			// Console.WriteLine($"Adicionando item na posição {_proximaPosicao + 1}");
			_itens[_proximaPosicao] = item;
			_proximaPosicao++;
		}

		public void AdicionarVarios(params object[] itens)
		{
			// for(int i = 0; i < itens.Length; i++)
			// {
			// 	Adicionar(_itens[i]);
			// }
			foreach(object item in itens)
			{
				Adicionar(item);
			}
		}

		public void Remover(object item)
		{
			int indiceItem = -1;
			for(int i = 0; i < this._proximaPosicao - 1; i++)
			{
				var itemAtual = _itens[i];
				
				if(itemAtual.Equals(item))
				{
					indiceItem = i;
					break;
				}
			}

			for (int i = indiceItem; i < _proximaPosicao; i++)
			{
				_itens[i] = _itens[i+1];
			}

			_proximaPosicao--;
			_itens[_proximaPosicao] = null;
		}

		public object GetItemNoIndice(int indice)
		{
			if (indice < 0 || indice >= _proximaPosicao)
			{
				throw new ArgumentOutOfRangeException(nameof(indice));
			}

			return _itens[indice];
		}

		public object this[int indice]
		{
			get
			{
				return GetItemNoIndice(indice);
			}
		}

		public object[] this[params int[] indices]
		{
			get
			{
				object[] resultado = new object[indices.Length];
				for (int i = 0; i < indices.Length; i++)
				{
					int indiceDaLista = indices[i];
					resultado[i] = GetItemNoIndice(indiceDaLista);
				}
				return resultado;
			}
		}

		private void VerificarCapacidade(int tamanhoNecessario)
		{
			if(_itens.Length >= tamanhoNecessario)
			{
				return;
			}
			
			int novoTamanho = _itens.Length * 2;

			// Console.WriteLine($"\nAumentando array: {novoTamanho} posições.");
			object[] novoArray = new object[novoTamanho];

			for(int i = 0; i < _itens.Length; i++)
			{
				novoArray[i] = _itens[i];
			}

			_itens = novoArray;
		}

		public void MeuMetodo (string texto = "gsdfggs", int numero = 5)
		{
			
		}
    }
}