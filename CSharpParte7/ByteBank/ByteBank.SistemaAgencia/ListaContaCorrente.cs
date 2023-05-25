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

		private void VerificarCapacidade(int tamanhoNecessario){
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
    }
}