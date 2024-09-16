using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApi.Core.Response
{
    public static class ResponseMessages
    {
        public const string OrderNotFound = "Pedido não encontrado";
        public const string OrderFoundWithSuccess = "Pedido recuperado com sucesso!";
        public const string OrderProcessedWithSuccess = "Pedido processado com sucesso!";
        public const string ClientIdAlreadyExist = "Já existe um cliente com este Id!";

    }
}
