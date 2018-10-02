using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex1POO.Dominio {
    class Pedido {
        public int codigo { get; set; }
        public DateTime data { get; set; }
        public List<ItemPedido> itens { get; set; }

        public Pedido(int codigo, int dia, int mes, int ano) {
            this.codigo = codigo;
            data = new DateTime(ano, mes, dia);
            itens = new List<ItemPedido>();
        }

        public double valorTotal() {
            double soma = 0.0;
            for (int i = 0; i<itens.Count; i++) {
                soma = soma + itens[i].subTotal();
            }
            return soma;
        }

        public override string ToString() {
            String s = "Pedido: "
                + codigo
                + ", Data: "
                + data.Day + "/" + data.Month + "/" + data.Year + "\n"
                + "Itens: \n";
                for (int i=0; i<itens.Count; i++) {
                s = s + itens[i] + "\n";
            }
                s = s + "Total do pedido: " + valorTotal().ToString("F2", CultureInfo.InvariantCulture);
                return s;
        }

    }
}
