using fastFood.Itens;
using fastFood.Clientes;
using fastFood.Endereços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;


namespace fastFood.Pedidos
{
    public class Pedido
    {
        public double valorDoPedido;
        public Cliente cliente;
        public Endereco endereco;
        public Item itens;
    }
}
