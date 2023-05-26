using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public class ListaContaCorrente
	{
        private ContaCorrente[] _itens;
		private int _proximaPosicao;

		public ListaContaCorrente(int tamanhoInicial = 1)
		{
			_itens = new ContaCorrente[tamanhoInicial];
			_proximaPosicao = 0;
		}

		public void Adicionar(ContaCorrente item)
		{
			VerificarCapacidade(_proximaPosicao + 1);

			Console.WriteLine($"Adicionando item na posição {_proximaPosicao + 1}");
			_itens[_proximaPosicao] = item;
			_proximaPosicao++;
		}

		public void Remover(ContaCorrente item)
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

		public void ExibirLista()
		{
			Console.WriteLine("\nExibindo lista de contas...");
			for(int i = 0; i < _proximaPosicao; i++)
			{
				var conta = _itens[i];
				Console.WriteLine($"Conta no índice {i}: número {conta.Conta}, agência {conta.Agencia}");
			}
		}

		private void VerificarCapacidade(int tamanhoNecessario)
		{
			if(_itens.Length >= tamanhoNecessario)
			{
				return;
			}
			
			int novoTamanho = _itens.Length * 2;

			Console.WriteLine($"\nAumentando array: {novoTamanho} posições.");
			ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

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