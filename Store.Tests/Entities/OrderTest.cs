using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using Store.Domain.Enums;

namespace Store.Tests.Domain
{
    [TestClass]
    public class OrderTests
    {

        private readonly Customer _customer = new Customer("Italo", "italocassio@gmail.com");
        private readonly Product _product = new Product("Produto", 10, true);
        private readonly Discount _discount = new Discount(10, DateTime.Now.AddDays(5));

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_novo_pedido_valido_ele_deve_gerar_um_numero_com_8_caracteres()
        {
            var pOrdem = new Order(_customer,0, null);

            Assert.AreEqual(8,pOrdem.Number.Length);

        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_novo_pedido_seu_status_deve_ser_aguardando_pagamento()
        {
            var pOrdem = new Order(_customer,0, null);

            Assert.AreEqual(EOrderStatus.WaitingPayment, pOrdem.Status);

        }
    }
}