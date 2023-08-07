using Mostenirea.Mostenire3;
using Polimorfizul.Mostenire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Teste
{
    public class Polimorfismul
    {

        private ControllerPersoane controller;

        private readonly ITestOutputHelper output;

        public Polimorfismul(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void verificare()
        {

            Admin admin = new Admin(true,"admin1234",5, "admin1","admin");
            Client client = new Client("client1234", true, 6, "client1", "client");

            output.WriteLine(client.descriere());


            Persoana p = client;



            output.WriteLine(p.descriere());


            p = admin;


            output.WriteLine(p.descriere());

        }

    }
}
