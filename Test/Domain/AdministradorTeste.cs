using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dominio.Entidades;


namespace Test.Domain
{
    [TestClass]
    public class AdministradorTeste
    {
       [TestMethod]
        public void TestasGetSetPropriedades()
        {
            //arrange
            var adm = new Administrador();
            //act
            adm.Id = 1;
            adm.Email = "teste@teste.com";
            adm.Senha = "teste";
            adm.Perfil = "Adm";

            //Assert
            Assert.AreEqual(1, adm.Id);
            Assert.AreEqual("teste@teste.com", adm.Email);
            Assert.AreEqual("teste", adm.Senha);
            Assert.AreEqual("Adm", adm.Perfil);

        } 
    }
}