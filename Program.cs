using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Person> hosts = new List<Person>();

Person p1 = new Person(name: "Hóspede 1");
Person p2 = new Person(name: "Hóspede 2");

hosts.Add(p1);
hosts.Add(p2);

// Cria a suíte
Suite suite = new Suite(suiteType: "Premium", capacity: 2, pricePerDay: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
SuiteBooking suiteBooking = new SuiteBooking(reservedDays: 12);
suiteBooking.RegisterSuite(suite);
suiteBooking.RegisterHosts(hosts);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {suiteBooking.GetTotalHosts()}");
Console.WriteLine($"Valor diária: {suiteBooking.GetTotalPrice()}");