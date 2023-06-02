using ByteBankIO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output
using System.Globalization;
using System.Xml.Schema;
using System.Xml;

namespace ByteBankIO
{
	partial class Program
	{
		static void Main(string[] args)
		{
			EscritorBinario();
			LeitorBinario();
		}
	}
}
