using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WFA
{
    internal interface IAdministrator
    {
        void AdaugareFilme(Film film);
        void StergereFilme(Film film);
        void IstoricClient(Client client);
    }
}
